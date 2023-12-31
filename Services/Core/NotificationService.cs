using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Services.SignalR;

namespace Services.Core;

public interface INotificationService
{
    Task<ResultModel> Add(NotificationCreateModel model);
    Task<ResultModel> Get(PagingParam<NotificationSortCriteria> paginationModel, NotiSearchModel searchModel, Guid userId);
    Task<ResultModel> GetById(int Id);
    Task<ResultModel> SeenNotification(int id, Guid userId);
    Task<ResultModel> DeleteNotification(int id, Guid userId);
}

public class NotificationService : INotificationService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly INotificationHub _notificationHub;
    private readonly IFireBaseNotificationService _fireBaseNotificationService;
    public NotificationService(AppDbContext dbContext, IMapper mapper, INotificationHub notificationHub, IFireBaseNotificationService fireBaseNotificationService)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _notificationHub = notificationHub;
        _fireBaseNotificationService = fireBaseNotificationService;
    }

    public async Task<ResultModel> Add(NotificationCreateModel notification)
    {
        var result = new ResultModel();

        try
        {
            var data = _mapper.Map<Notification>(notification);
            _dbContext.Notifications.Add(data);
            dynamic userReceive = _dbContext.Users.Where(_ => _.Id == notification.UserId && !_.IsDeleted).FirstOrDefault();
            if (userReceive == null)
            {
                userReceive = _dbContext.Customers.FirstOrDefault(x => x.Id == notification.UserId);
            }
            userReceive!.FcmTokens = await SendNotifyFcm(notification.UserId, data, notification.Title, notification.Body);
            _dbContext.Update(userReceive);
            _dbContext.SaveChanges();
            await _notificationHub.NewNotification(_mapper.Map<Notification, NotificationModel>(data), notification.UserId.ToString());
            await _notificationHub.NewNotificationCount(userReceive.CurrenNoticeCount, userReceive.Id.ToString());
            result.Succeed = true;
            result.Data = notification;
        }
        catch (Exception e)
        {
            var r = e;
        }
        return result;
    }

    public async Task<ResultModel> Get(PagingParam<NotificationSortCriteria> paginationModel, NotiSearchModel searchModel, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        try
        {
            var notifications = _dbContext.Notifications
                .Where(delegate (Notification x)
                {
                    return x.Filter(searchModel);
                })
                .Where(_ => _.UserId == userId && !_.IsDeleted)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, notifications.Count());

            notifications = notifications.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            notifications = notifications.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<NotificationModel>>(notifications.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    public async Task<ResultModel> GetById(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;
        try
        {
            var notification = _dbContext.Notifications.Where(_ => _.Id == id && !_.IsDeleted).FirstOrDefault();
            var viewData = _mapper.Map<NotificationModel>(notification);
            result.Succeed = true;
            result.Data = viewData;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    public async Task<ResultModel> SeenNotification(int id, Guid userId)
    {
        var result = new ResultModel();
        try
        {
            var notification = _dbContext.Notifications.Where(_ => _.Id == id && _.UserId == userId && !_.IsDeleted).FirstOrDefault();
            if (notification == null)
            {
                result.Succeed = false;
                result.ErrorMessage = "Notification not found";
                return result;
            }
            notification.Seen = true;
            notification.DateUpdated = DateTime.Now;
            _dbContext.Notifications.Update(notification);
            _dbContext.SaveChanges();
            result.Data = notification.Id;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    public async Task<ResultModel> DeleteNotification(int id, Guid userId)
    {
        var result = new ResultModel();
        try
        {
            var notification = _dbContext.Notifications.Where(_ => _.Id == id && _.UserId == userId && !_.IsDeleted).FirstOrDefault();
            if (notification == null)
            {
                result.Succeed = false;
                result.ErrorMessage = "Notification not found";
                return result;
            }
            _dbContext.Notifications.Remove(notification);
            _dbContext.SaveChanges();
            result.Data = notification.Id;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = e.Message + "\n" + (e.InnerException != null ? e.InnerException.Message : "") + "\n ***Trace*** \n" + e.StackTrace;
        }
        return result;
    }

    private async Task<List<string>> SendNotifyFcm(Guid userId, Notification data, string title, string body)
    {
        dynamic userReceive = _dbContext.User.FirstOrDefault(x => x.Id == userId);
        if (userReceive == null)
        {
            userReceive = _dbContext.Customers.FirstOrDefault(x => x.Id == userId);
        }
        var fcmTokens = userReceive.FcmTokens;

        try
        {
            if (userReceive != null)
            {
                userReceive.CurrenNoticeCount++;
                if (userReceive.FcmTokens.Count > 0)
                {
                    var result = new NotificationFcmModel
                    {
                        Title = title,
                        Body = body,
                        Data = data,
                        RegistrationIds = userReceive.FcmTokens.ToList(),
                        UserId = userReceive.Id,
                    };
                    var response = await _fireBaseNotificationService.SendNotification(result);
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var fcmResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<FcmResponse>(responseContent);
                    if (response.IsSuccessStatusCode)
                    {
                        if (fcmResponse.Failure != 0)
                        {
                            for (int i = 0; i < fcmResponse.Results.Count; i++)
                            {
                                if (fcmResponse.Results[i].Error != null)
                                {
                                    if (userReceive.FcmTokens.Contains(result.RegistrationIds[i]))
                                    {
                                        fcmTokens.Remove(result.RegistrationIds[i]);
                                    }
                                }
                            }

                        }
                    }
                }
            }

        }
        catch (Exception ex)
        {
            var er = ex;
        }
        return fcmTokens;
    }
}