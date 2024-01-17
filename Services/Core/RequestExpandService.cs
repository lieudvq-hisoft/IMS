using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Common;
using Data.Utils.Paging;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;
using System.Text.Json;

namespace Services.Core;
public interface IRequestExpandService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetAppointment(int requestExpandId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> Create(RequestExpandCreateModel model);
    Task<ResultModel> Update(RequestExpandUpdateModel model);
    Task<ResultModel> Delete(int requestExpandId);
    Task<ResultModel> Reject(int requestExpandId, RequestExpandRejectModel modell);
    Task<ResultModel> Accept(int requestExpandId, Guid userId, EvaluateModel model);
    Task<ResultModel> Deny(int requestExpandId, Guid userId, EvaluateModel model);
    //Task<ResultModel> DeleteRequestExpandLocation(int requestExpandId);
    Task<ResultModel> AssignLocation(int requestExpandId, RequestExpandAssignLocationModel model);
    //Task<ResultModel> GetChosenLocation(int requestExpandId);
    Task<ResultModel> GetRackChoiceSuggestionBySize(int requestExpandId);
}

public class RequestExpandService : IRequestExpandService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly ICloudinaryHelper _cloudinaryHelper;
    private readonly INotificationService _notiService;

    public RequestExpandService(AppDbContext dbContext, IMapper mapper, INotificationService notiService, ICloudinaryHelper cloudinaryHelper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
        _cloudinaryHelper = cloudinaryHelper;
        _notiService = notiService;
    }

    public async Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpands = _dbContext.RequestExpands
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer).ThenInclude(x => x.UserCustomers)
                .Include(x => x.RequestExpandUsers).ThenInclude(x => x.User)
                .Where(x => (x.ServerAllocation.Name ?? "").Contains(searchModel.SearchValue) || searchModel.SearchValue == null)
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
                .Where(x => searchModel.ServerAllocationId != null ? x.ServerAllocationId == searchModel.ServerAllocationId : true)
                .Where(x => searchModel.Statuses != null ? searchModel.Statuses.Contains(x.Status) : true)
                .Where(x => searchModel.UserId != null ? x.ServerAllocation.Customer.UserCustomers.Any(x => x.UserId == searchModel.UserId) : true)
                .Where(x => searchModel.CustomerId != null ? x.ServerAllocation.CustomerId == searchModel.CustomerId : true)
                .Where(x => searchModel.AppointmentId != null ? x.RequestExpandAppointments.Any(x => x.AppointmentId == searchModel.AppointmentId) : true)
                .Where(x => x.ForRemoval == searchModel.IsRemoval || searchModel.IsRemoval == null)
                .AsQueryable();

            var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, requestExpands.Count());

            requestExpands = requestExpands.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
            requestExpands = requestExpands.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

            paging.Data = _mapper.Map<List<RequestExpandModel>>(requestExpands.ToList());

            result.Data = paging;
            result.Succeed = true;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetDetail(int id)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location)
                .Include(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestExpandUsers).ThenInclude(x => x.User)
                .FirstOrDefault(x => x.Id == id);

            if (requestExpand != null)
            {
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandModel>(requestExpand);
            }
            else
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                result.Succeed = false;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    public async Task<ResultModel> GetAppointment(int requestExpandId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel)
    {
        var result = new ResultModel();
        result.Succeed = false;

        var searchValue = searchModel.SearchValue?.ToLower() ?? "";
        var appointments = _dbContext.Appointments
            .Include(x => x.ServerAllocation).ThenInclude(x => x.IpAssignments).ThenInclude(x => x.IpAddress)
            .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
            .Include(x => x.AppointmentUsers).ThenInclude(x => x.User)
            .Include(x => x.RequestExpandAppointments)
            .Include(x => x.RequestUpgradeAppointment)
            .Include(x => x.AppointmentUsers)
            .Where(x => x.RequestExpandAppointments.Any(x => x.RequestExpandId == requestExpandId))
            .Where(x => x.ServerAllocationId == searchModel.ServerAllocationId || searchModel.ServerAllocationId == null)
            .Where(x => searchModel.Statuses.Contains(x.Status) || searchModel.Statuses == null)
            .Where(x => searchModel.Reasons.Contains(x.Reason) || searchModel.Reasons == null)
            .Where(x => x.ServerAllocation.CustomerId == searchModel.CustomerId || searchModel.CustomerId == null)
            .Where(x => x.AppointmentUsers.Any(x => x.UserId == searchModel.UserId) || searchModel.UserId == null)
            .Where(x => x.AppointedCustomer.ToLower().Contains(searchValue) || x.ServerAllocation.Customer.CompanyName.Contains(searchValue))
            .AsQueryable();

        var paging = new PagingModel(paginationModel.PageIndex, paginationModel.PageSize, appointments.Count());

        appointments = appointments.GetWithSorting(paginationModel.SortKey.ToString(), paginationModel.SortOrder);
        appointments = appointments.GetWithPaging(paginationModel.PageIndex, paginationModel.PageSize);

        paging.Data = _mapper.Map<List<AppointmentModel>>(appointments.ToList());

        result.Data = paging;
        result.Succeed = true;

        return result;
    }

    public async Task<ResultModel> Create(RequestExpandCreateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var serverAllocation = _dbContext.ServerAllocations
                .Include(x => x.RequestExpands)
                .Include(x => x.ServerHardwareConfigs).ThenInclude(x => x.Component)
                .Include(x => x.LocationAssignments).ThenInclude(x => x.Location)
                .FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            var requiredComponents = _dbContext.Components.Where(x => x.IsRequired);
            if (serverAllocation == null)
            {
                validPrecondition = false;
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else if (serverAllocation.RequestExpands.Any(x => x.ForRemoval == model.ForRemoval && x.Status == RequestStatus.Accepted || x.Status == RequestStatus.Waiting))
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.EXISTED;
            }
            else if (!model.ForRemoval && serverAllocation.LocationAssignments.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = LocationAssignmentErrorMessage.EXISTED;
            }
            else if (model.ForRemoval && !serverAllocation.LocationAssignments.Any())
            {
                validPrecondition = false;
                result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
            }
            else if (model.ForRemoval && model.Size != null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Can not specify size for removal request";
            }
            else if (model.ForRemoval && model.RemovalRequestDocument == null)
            {
                validPrecondition = false;
                result.ErrorMessage = "Request for removal require removal document";
            }
            else
            {
                foreach (var component in requiredComponents)
                {
                    if (serverAllocation.ServerHardwareConfigs?.FirstOrDefault(x => x.ComponentId == component.Id) == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = "Cannot allocate server missing config for required component";
                    }
                }
            }

            if (validPrecondition)
            {
                var requestExpand = _mapper.Map<RequestExpand>(model);
                requestExpand.Status = RequestStatus.Waiting;
                if (requestExpand.ForRemoval)
                {
                    requestExpand.RequestType = RequestType.RemoveLocation;
                    requestExpand.Size = serverAllocation.LocationAssignments.Count();
                    string removalDocument = _cloudinaryHelper.UploadFile(model.RemovalRequestDocument);
                    requestExpand.RemovalRequestDocument = removalDocument;
                }
                _dbContext.RequestExpands.Add(requestExpand);
                _dbContext.SaveChanges();

                var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale")).ToList();
                var requestExpandModelString = JsonSerializer.Serialize(_mapper.Map<RequestExpandResultModel>(requestExpand));
                foreach (var sale in sales)
                {
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = sale.Id,
                        Action = "Created",
                        Title = $"New server {(requestExpand.ForRemoval ? "remove" : "allocate")} request",
                        Body = $"There's a new server {(requestExpand.ForRemoval ? "remove" : "allocate")} request just created",
                        Data = new NotificationData
                        {
                            Key = "RequestExpand",
                            Value = requestExpandModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandResultModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Update(RequestExpandUpdateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.ServerAllocation).FirstOrDefault(x => x.Id == model.Id && x.ServerAllocation.Status != ServerAllocationStatus.Removed);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.Status != RequestStatus.Accepted && requestExpand.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = "Request must be waiting or accepted";
            }
            else
            {
                if (requestExpand.Status != RequestStatus.Accepted)
                {
                    model.Size = 0;
                }
                _mapper.Map<RequestExpandUpdateModel, RequestExpand>(model, requestExpand);
                _dbContext.SaveChanges();

                result.Succeed = true;
                result.Data = _mapper.Map<RequestExpandResultModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Delete(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.ServerAllocation).Include(x => x.RequestExpandLocations).FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_WAITING;
            }
            else
            {
                requestExpand.Status = RequestStatus.Failed;
                _dbContext.RequestExpandLocations.RemoveRange(requestExpand.RequestExpandLocations);
                _dbContext.SaveChanges();

                var sales = _dbContext.Users
                    .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .Where(x => x.UserRoles.Select(x => x.Role).Any(x => x.Name == "Sale")).ToList();
                var reuqestExpandModelString = JsonSerializer.Serialize(_mapper.Map<RequestExpandResultModel>(requestExpand));
                foreach (var sale in sales)
                {
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = sale.Id,
                        Action = "Canceled",
                        Title = "Allocation request canceled",
                        Body = "There's an allocation request just canceled by customer",
                        Data = new NotificationData
                        {
                            Key = "RequestExpand",
                            Value = reuqestExpandModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = requestExpand.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Reject(int requestExpandId, RequestExpandRejectModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.ServerAllocation).FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.Status != RequestStatus.Accepted)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_ACCEPTED;
            }
            else
            {
                requestExpand.Status = RequestStatus.Failed;
                if (model.SaleNote != null)
                {
                    requestExpand.SaleNote = model.SaleNote;
                }
                if (model.TechNote != null)
                {
                    requestExpand.TechNote = model.TechNote;
                }
                _dbContext.SaveChanges();

                var reuqestExpandModelString = JsonSerializer.Serialize(_mapper.Map<RequestExpandResultModel>(requestExpand));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = requestExpand.ServerAllocation.CustomerId,
                    Action = "Failed",
                    Title = "Allocation request failed",
                    Body = "There's an allocation request just failed",
                    Data = new NotificationData
                    {
                        Key = "RequestExpand",
                        Value = reuqestExpandModelString
                    }
                });
                result.Succeed = true;
                result.Data = requestExpandId;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    //public async Task<ResultModel> FailRemoval(int requestExpandId)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        var requestExpand = _dbContext.RequestExpands.Include(x => x.ServerAllocation).Include(x => x.RequestExpandAppointments).FirstOrDefault(x => x.Id == requestExpandId);
    //        if (requestExpand == null)
    //        {
    //            result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
    //        }
    //        else if (requestExpand.Status != RequestStatus.Success)
    //        {
    //            result.ErrorMessage = RequestExpandErrorMessage.NOT_SUCCESS;
    //        }
    //        else if (requestExpand.RemovalStatus != RemovalStatus.Accepted)
    //        {
    //            result.ErrorMessage = RequestExpandErrorMessage.REMOVAL_NOT_ACCEPTED;
    //        }
    //        else
    //        {
    //            requestExpand.RemovalStatus = RemovalStatus.Failed;
    //            _dbContext.RequestExpandAppointments.RemoveRange(requestExpand.RequestExpandAppointments);

    //            var reuqestHostModelString = JsonSerializer.Serialize(_mapper.Map<RequestExpandResultModel>(requestExpand));
    //            await _notiService.Add(new NotificationCreateModel
    //            {
    //                UserId = requestExpand.ServerAllocation.CustomerId,
    //                Action = "Failed",
    //                Title = "Allocation removal request failed",
    //                Body = "There's an allocation removal request just failed",
    //                Data = new NotificationData
    //                {
    //                    Key = "RequestExpand",
    //                    Value = reuqestHostModelString
    //                }
    //            });
    //            _dbContext.SaveChanges();
    //            result.Succeed = true;
    //            result.Data = requestExpand.Id;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    public async Task<ResultModel> Accept(int requestExpandId, Guid userId, EvaluateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.ServerAllocation).FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestExpand.Status != RequestStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.NOT_WAITING;
            }

            if (validPrecondition)
            {
                requestExpand.Status = RequestStatus.Accepted;
                _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                {
                    RequestExpandId = requestExpandId,
                    UserId = userId,
                    Action = RequestUserAction.Evaluate
                });
                if (!string.IsNullOrEmpty(model.SaleNote))
                {
                    requestExpand.SaleNote = model.SaleNote;
                }
                requestExpand.DateEvaluated = DateTime.Now;
                if (requestExpand.ForRemoval)
                {
                    requestExpand.ServerAllocation.Status = ServerAllocationStatus.Pausing;
                }
                _dbContext.SaveChanges();

                var requestExpandModelString = JsonSerializer.Serialize(_mapper.Map<RequestExpandResultModel>(requestExpand));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = requestExpand.ServerAllocation.CustomerId,
                    Action = "Accepted",
                    Title = "Allocation request accepted",
                    Body = "There's an allocation request just accepted",
                    Data = new NotificationData
                    {
                        Key = "RequestExpand",
                        Value = requestExpandModelString
                    }
                });
                if (requestExpand.ForRemoval)
                {
                    var serverModelString = JsonSerializer.Serialize(_mapper.Map<ServerAllocationResultModel>(requestExpand.ServerAllocation));
                    await _notiService.Add(new NotificationCreateModel
                    {
                        UserId = requestExpand.ServerAllocation.CustomerId,
                        Action = "Paused",
                        Title = "Server paused",
                        Body = "There's an server just paused",
                        Data = new NotificationData
                        {
                            Key = "ServerAllocation",
                            Value = serverModelString
                        }
                    });
                }
                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> Deny(int requestExpandId, Guid userId, EvaluateModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.RequestExpandAppointments)
                .Include(x => x.ServerAllocation)
                .FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestExpand.Status != RequestStatus.Waiting)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.NOT_WAITING;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition)
            {
                requestExpand.Status = RequestStatus.Denied;
                requestExpand.DateEvaluated = DateTime.Now;
                requestExpand.SaleNote = model.SaleNote;
                _dbContext.RequestExpandAppointments.RemoveRange(requestExpand.RequestExpandAppointments);
                _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                {
                    Action = RequestUserAction.Evaluate,
                    RequestExpandId = requestExpand.Id,
                    UserId = userId
                });
                _dbContext.SaveChanges();

                var reuqestExpandModelString = JsonSerializer.Serialize(_mapper.Map<RequestExpandResultModel>(requestExpand));
                await _notiService.Add(new NotificationCreateModel
                {
                    UserId = requestExpand.ServerAllocation.CustomerId,
                    Action = "Denied",
                    Title = "Allocaton request denied",
                    Body = "There's an allocation request just denied",
                    Data = new NotificationData
                    {
                        Key = "RequestExpand",
                        Value = reuqestExpandModelString
                    }
                });
                result.Succeed = true;
                result.Data = _mapper.Map<RequestHostModel>(requestExpand);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> AssignLocation(int requestExpandId, RequestExpandAssignLocationModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment).Include(x => x.RequestExpandLocations).FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.ForRemoval)
            {
                validPrecondition = false;
                result.ErrorMessage = "Cannot assign location to removing server request";
            }
            else
            {
                if (requestExpand.RequestExpandLocations.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestExpandLocationErrorMessage.EXISTED;
                }

                if (requestExpand.Status != RequestStatus.Accepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestExpandErrorMessage.NOT_ACCEPTED;
                }

                if (requestExpand.Size == null)
                {
                    validPrecondition = false;
                    result.ErrorMessage = "Cannot assign location without size";
                }
            }

            if (validPrecondition)
            {
                var appointmentAccepted = requestExpand.RequestExpandAppointments.Where(x => !x.ForRemoval).Select(x => x.Appointment).Any(x => x.Status == RequestStatus.Accepted);
                if (!appointmentAccepted)
                {
                    validPrecondition = false;
                    result.ErrorMessage = AppointmentErrorMessage.NOT_ACCEPTED;
                }
            }

            List<Location> locations = null;
            if (validPrecondition)
            {
                locations = _dbContext.Locations
                    .Include(x => x.LocationAssignments)
                    .Include(x => x.RequestExpandLocations).ThenInclude(x => x.RequestExpand)
                    .Where(x => x.RackId == model.RackId && x.Position >= model.StartPosition && x.Position < model.StartPosition + requestExpand.Size.Value && !x.IsReserved).ToList();
                if (locations.Count != requestExpand.Size.Value)
                {
                    validPrecondition = false;
                    result.ErrorMessage = RequestExpandLocationErrorMessage.INVALID_LOCATION;
                }
                else
                {
                    validPrecondition = CheckValidLocation(locations, requestExpandId, result);
                }
            }

            if (validPrecondition)
            {
                foreach (var location in locations)
                {
                    _dbContext.RequestExpandLocations.Add(new RequestExpandLocation
                    {
                        LocationId = location.Id,
                        RequestExpandId = requestExpandId,
                    });
                }
                _dbContext.SaveChanges();
                requestExpand = _dbContext.RequestExpands
                    .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area)
                    .FirstOrDefault(x => x.Id == requestExpandId);
                requestExpand.ChosenLocation = GetChosenLocation(requestExpand);
                _dbContext.SaveChanges();
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private string GetChosenLocation(RequestExpand requestExpand)
    {
        var locations = requestExpand.RequestExpandLocations.Select(x => x.Location);
        var rack = locations.Select(x => x.Rack).Distinct().FirstOrDefault();
        var startPosition = locations.Select(x => x.Position).Min();
        var endPosition = locations.Select(x => x.Position).Max();
        return $"{rack.Area.Name + 1}{rack.Column + 1}-{rack.Row} U{startPosition + 1}-U{endPosition + 1}";
    }

    private bool CheckValidLocation(List<Location> locations, int requestExpandId, ResultModel result)
    {
        bool allValidLocation = true;
        foreach (var location in locations)
        {
            if (location.LocationAssignments.Any())
            {
                allValidLocation = false;
                result.ErrorMessage = LocationAssignmentErrorMessage.EXISTED;
            }
            else if (location.RequestExpandLocations.Select(x => x.RequestExpand).Any(x => (x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted) && x.Id != requestExpandId))
            {
                allValidLocation = false;
                result.ErrorMessage = RequestExpandLocationErrorMessage.EXISTED;
            }
        }

        return allValidLocation;
    }

    //public async Task<ResultModel> GetChosenLocation(int requestExpandId)
    //{
    //    var result = new ResultModel();
    //    result.Succeed = false;

    //    try
    //    {
    //        var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.Rack).ThenInclude(x => x.Area).FirstOrDefault(x => x.Id == requestExpandId);
    //        if (requestExpand == null)
    //        {
    //            result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
    //        }
    //        if (!requestExpand.RequestExpandLocations.Any())
    //        {
    //            result.ErrorMessage = "Request expand dont have any chosen location";
    //        }
    //        else
    //        {
    //            var rack = requestExpand.RequestExpandLocations.Select(x => x.Location.Rack).DistinctBy(x => x.Id).FirstOrDefault();
    //            var suggestedLocation = new LocationSuggestResultModel
    //            {
    //                Area = _mapper.Map<AreaResultModel>(rack?.Area),
    //                Rack = _mapper.Map<RackResultModel>(rack),
    //                Position = requestExpand.RequestExpandLocations.Select(x => x.Location.Position).Min()
    //            };

    //            result.Succeed = true;
    //            result.Data = suggestedLocation;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        result.ErrorMessage = MyFunction.GetErrorMessage(e);
    //    }

    //    return result;
    //}

    public async Task<ResultModel> GetRackChoiceSuggestionBySize(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        LocationSuggestResultModel suggestedLocation = null;
        try
        {
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.Size == null || requestExpand.Size == 0)
            {
                result.ErrorMessage = "Cannot suggest without size";
            }
            else
            {
                var racks = _dbContext.Racks.Include(x => x.Locations).Include(x => x.Area).OrderBy(x => x.Id).ToList();
                int rackCount = 0;
                while (rackCount < racks.Count && suggestedLocation == null)
                {
                    var rack = racks[rackCount];
                    var suggestedStartingLocation = CheckRackAvailabilityLocation(rack, requestExpand.Size.Value);
                    if (suggestedStartingLocation != null)
                    {
                        suggestedLocation = new LocationSuggestResultModel
                        {
                            Area = _mapper.Map<AreaResultModel>(rack.Area),
                            Rack = _mapper.Map<RackResultModel>(rack),
                            Position = suggestedStartingLocation.Position
                        };
                    }
                    rackCount++;
                }
                if (suggestedLocation == null)
                {
                    result.ErrorMessage = LocationErrorMessgae.NO_AVAILABLE_FOUND;
                }
                else
                {
                    result.Data = suggestedLocation;
                    result.Succeed = true;
                }
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }
        return result;
    }

    private Location CheckRackAvailabilityLocation(Rack rack, int size)
    {
        Location suggestedStartingLocation = null;
        var spaces = new List<List<Location>>(1);
        var availableLocations = _dbContext.Locations
            .Include(x => x.LocationAssignments)
            .Include(x => x.RequestExpandLocations).ThenInclude(x => x.RequestExpand)
            .Where(x => x.RackId == rack.Id && !x.IsReserved && !x.LocationAssignments.Any() && !x.RequestExpandLocations.Select(x => x.RequestExpand).Any(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted));
        int count = 0;
        var isEmpty = false;
        for (int i = 0; i < rack.Size; i++)
        {
            var location = availableLocations.FirstOrDefault(x => x.Position == i);
            if (location != null)
            {
                if (spaces.Count < count + 1)
                {
                    spaces.Add(new List<Location>());
                }
                spaces[count].Add(location);
                isEmpty = false;
            }
            else
            {
                if (!isEmpty)
                {
                    spaces.Add(new List<Location>());
                    count++;
                    isEmpty = true;
                }
            }
        }
        int spaceCount = 0;
        while (spaceCount < spaces.Count && suggestedStartingLocation == null)
        {
            var space = spaces[spaceCount];
            if (space.Count >= size)
            {
                suggestedStartingLocation = space[0];
            }
            spaceCount++;
        }
        return suggestedStartingLocation;
    }
}