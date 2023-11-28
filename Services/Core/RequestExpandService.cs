using AutoMapper;
using Data.Common.PaginationModel;
using Data.DataAccess;
using Data.DataAccess.Constant;
using Data.Entities;
using Data.Enums;
using Data.Models;
using Data.Utils.Paging;
using Microsoft.EntityFrameworkCore;
using Services.Utilities;

namespace Services.Core;
public interface IRequestExpandService
{
    Task<ResultModel> Get(PagingParam<BaseSortCriteria> paginationModel, RequestExpandSearchModel searchModel);
    Task<ResultModel> GetDetail(int id);
    Task<ResultModel> GetAppointment(int requestExpandId, PagingParam<BaseSortCriteria> paginationModel, AppointmentSearchModel searchModel);
    Task<ResultModel> Create(RequestExpandCreateModel model);
    Task<ResultModel> Update(RequestExpandUpdateModel model);
    Task<ResultModel> Delete(int requestExpandId);
    Task<ResultModel> Reject(RequestExpandDeleteModel model);
    Task<ResultModel> FailRemoval(int requestExpandId);
    Task<ResultModel> Evaluate(int requestExpandId, RequestStatus status, Guid userId);
    Task<ResultModel> DeleteRequestExpandLocation(int requestExpandId);
    Task<ResultModel> AssignLocation(int requestExpandId, RequestExpandAssignLocationModel model);
    Task<ResultModel> Complete(int requestExpandId, Guid userId);
    Task<ResultModel> CompleteBulk(RequestExpandCompleteBulkModel model, Guid userId);
    Task<ResultModel> CompleteRemoval(int requestExpandId, Guid userId);
    Task<ResultModel> CompleteRemovalBulk(RequestExpandCompleteBulkModel model, Guid userId);
    Task<ResultModel> GetRackChoiceSuggestionBySize(int requestExpandId);

}

public class RequestExpandService : IRequestExpandService
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;

    public RequestExpandService(AppDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
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
                .Include(x => x.ServerAllocation).ThenInclude(x => x.Customer)
                .Include(x => x.RequestExpandUsers).ThenInclude(x => x.User)
                .Where(x => searchModel.Id != null ? x.Id == searchModel.Id : true)
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

        var appointments = _dbContext.Appointments
            .Include(x => x.ServerAllocation)
            .Include(x => x.RequestExpandAppointments)
            .Include(x => x.AppointmentUsers)
            .Where(x => x.RequestExpandAppointments.Any(x => x.RequestExpandId == requestExpandId))
            .Where(delegate (Appointment x)
            {
                return x.FilterAppointment(searchModel);
            }).AsQueryable();

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

        try
        {
            var serverAllocation = _dbContext.ServerAllocations.FirstOrDefault(x => x.Id == model.ServerAllocationId && x.Status != ServerAllocationStatus.Removed);
            if (serverAllocation == null)
            {
                result.ErrorMessage = ServerAllocationErrorMessage.NOT_EXISTED;
            }
            else
            {
                var requestExpand = _mapper.Map<RequestExpand>(model);
                requestExpand.Status = RequestStatus.Waiting;
                _dbContext.RequestExpands.Add(requestExpand);
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
            var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandLocations).FirstOrDefault(x => x.Id == requestExpandId);
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

    public async Task<ResultModel> Reject(RequestExpandDeleteModel model)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == model.Id);
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
                requestExpand.TechNote = model.TechNote;
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = model.Id;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> FailRemoval(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandAppointments).FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
            }
            else if (requestExpand.Status != RequestStatus.Success)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_SUCCESS;
            }
            else if (requestExpand.RemovalStatus != RemovalStatus.Accepted)
            {
                result.ErrorMessage = RequestExpandErrorMessage.REMOVAL_NOT_ACCEPTED;
            }
            else
            {
                requestExpand.RemovalStatus = RemovalStatus.Failed;
                _dbContext.RequestExpandAppointments.RemoveRange(requestExpand.RequestExpandAppointments);
                _dbContext.SaveChanges();
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

    public async Task<ResultModel> Evaluate(int requestExpandId, RequestStatus status, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            if (status != RequestStatus.Accepted && status != RequestStatus.Denied)
            {
                throw new Exception(ErrorMessage.WRONG_PURPOSE);
            }

            var requestExpand = _dbContext.RequestExpands.FirstOrDefault(x => x.Id == requestExpandId);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            var user = _dbContext.User.FirstOrDefault(x => x.Id == userId);
            if (user == null)
            {
                validPrecondition = false;
                result.ErrorMessage = UserErrorMessage.NOT_EXISTED;
            }

            if (validPrecondition && requestExpand.Status != RequestStatus.Waiting)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_WAITING;
                validPrecondition = false;
            }

            if (validPrecondition)
            {
                requestExpand.Status = status;
                _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                {
                    Action = RequestUserAction.Evaluate,
                    RequestExpandId = requestExpand.Id,
                    UserId = userId
                });
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

    public async Task<ResultModel> DeleteRequestExpandLocation(int requestExpandId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandLocations).FirstOrDefault(x => x.Id == requestExpandId);
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
                var requestExpandLocations = requestExpand.RequestExpandLocations;
                _dbContext.RequestExpandLocations.RemoveRange(requestExpandLocations);
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = requestExpandLocations.Select(x => x.Id);
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
                    result.ErrorMessage = "Cannot suggest without size";
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
                    .Where(x => x.RackId == model.RackId && x.Position >= model.StartPosition && x.Position < model.StartPosition + requestExpand.Size.Value).ToList();
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
                result.Succeed = true;
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
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

    public async Task<ResultModel> Complete(int requestExpandId, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.LocationAssignments).FirstOrDefault(x => x.Id == requestExpandId && x.Status == RequestStatus.Accepted);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }

            if (!IsCompletable(requestExpandId, false))
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_COMPLETABLE;
                validPrecondition = false;
            }

            List<Location> locations = null;
            if (validPrecondition)
            {
                locations = requestExpand.RequestExpandLocations.Select(x => x.Location).ToList();
                if (!locations.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = "Request dont have target location";
                }
                else
                {
                    validPrecondition = CheckValidLocation(locations, requestExpandId, result);
                }
            }

            if (validPrecondition)
            {
                var serverAllocation = requestExpand.ServerAllocation;
                bool haveLocation = serverAllocation.LocationAssignments.Any();
                var locationAssignments = new List<LocationAssignment>();
                foreach (var location in locations)
                {
                    locationAssignments.Add(new LocationAssignment
                    {
                        ServerAllocationId = requestExpand.ServerAllocationId,
                        LocationId = location.Id,
                        IsServer = !haveLocation
                    });
                }
                _dbContext.LocationAssignments.AddRange(locationAssignments);
                requestExpand.Status = RequestStatus.Success;
                _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                {
                    Action = RequestUserAction.Execute,
                    RequestExpandId = requestExpand.Id,
                    UserId = userId
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(locationAssignments);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private bool IsCompletable(int requestExpandId, bool forRemoval)
    {
        var requestExpand = _dbContext.RequestExpands.Include(x => x.RequestExpandAppointments).ThenInclude(x => x.Appointment).FirstOrDefault(x => x.Id == requestExpandId);
        if (requestExpand == null)
        {
            return false;
        }

        return requestExpand.RequestExpandAppointments.Where(x => x.ForRemoval == forRemoval).Select(x => x.Appointment).Any(x => x.Status == RequestStatus.Success);
    }

    public async Task<ResultModel> CompleteBulk(RequestExpandCompleteBulkModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            foreach (var requestExpandId in model.RequestExpandIds)
            {
                results.Add(await Complete(requestExpandId, userId));
            }

            if (results.Any(x => !x.Succeed))
            {
                result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = results.Select(x => x.Data);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CompleteRemoval(int requestExpandId, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;
        bool validPrecondition = true;

        try
        {
            var requestExpand = _dbContext.RequestExpands
                .Include(x => x.ServerAllocation).ThenInclude(x => x.ServerHardwareConfigs)
                .Include(x => x.ServerAllocation).ThenInclude(x => x.LocationAssignments)
                .Include(x => x.RequestExpandLocations).ThenInclude(x => x.Location).ThenInclude(x => x.LocationAssignments).FirstOrDefault(x => x.Id == requestExpandId && x.Status == RequestStatus.Success);
            if (requestExpand == null)
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_EXISTED;
                validPrecondition = false;
            }
            else if (requestExpand.RemovalStatus != RemovalStatus.Accepted)
            {
                validPrecondition = false;
                result.ErrorMessage = RequestExpandErrorMessage.REMOVAL_NOT_ACCEPTED;
            }

            if (!IsCompletable(requestExpandId, true))
            {
                result.ErrorMessage = RequestExpandErrorMessage.NOT_COMPLETABLE;
                validPrecondition = false;
            }

            List<Location> locations = null;
            if (validPrecondition)
            {
                locations = requestExpand.RequestExpandLocations.Select(x => x.Location).ToList();
                if (!locations.Any())
                {
                    validPrecondition = false;
                    result.ErrorMessage = "Request dont have target location";
                }
            }

            var locationAssignments = new List<LocationAssignment>();
            if (validPrecondition)
            {
                foreach (var location in locations)
                {
                    var locationAssignment = _dbContext.LocationAssignments.FirstOrDefault(x => x.LocationId == location.Id);
                    if (locationAssignment == null)
                    {
                        validPrecondition = false;
                        result.ErrorMessage = LocationAssignmentErrorMessage.NOT_EXISTED;
                    }
                    else
                    {
                        locationAssignments.Add(locationAssignment);
                    }
                }
            }

            if (validPrecondition)
            {
                _dbContext.LocationAssignments.RemoveRange(locationAssignments);
                requestExpand.RemovalStatus = RemovalStatus.Success;
                _dbContext.RequestExpandUsers.Add(new RequestExpandUser
                {
                    Action = RequestUserAction.Execute,
                    RequestExpandId = requestExpand.Id,
                    UserId = userId
                });
                _dbContext.SaveChanges();
                result.Succeed = true;
                result.Data = _mapper.Map<List<LocationAssignmentModel>>(locationAssignments);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> CompleteRemovalBulk(RequestExpandCompleteBulkModel model, Guid userId)
    {
        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            using var transaction = _dbContext.Database.BeginTransaction();
            var results = new List<ResultModel>();
            foreach (var requestRemovalId in model.RequestExpandIds)
            {
                results.Add(await CompleteRemoval(requestRemovalId, userId));
            }

            if (results.Any(x => !x.Succeed))
            {
                result.ErrorMessage = results.FirstOrDefault(x => !x.Succeed).ErrorMessage;
                transaction.Rollback();
            }
            else
            {
                transaction.Commit();
                result.Succeed = true;
                result.Data = results.Select(x => x.Data);
            }
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

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
            else if (requestExpand.Size == null)
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
            .Where(x => x.RackId == rack.Id && !x.LocationAssignments.Any() && !x.RequestExpandLocations.Select(x => x.RequestExpand).Any(x => x.Status == RequestStatus.Waiting || x.Status == RequestStatus.Accepted));

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