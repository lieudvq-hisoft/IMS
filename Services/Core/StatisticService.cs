using Data.DataAccess;
using Data.Entities;
using Data.Models;
using Data.Utils.Common;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace Services.Core;
public interface IStatisticService
{
    Task<ResultModel> GetRequestByMonth(StatisticSearchByTimeModel model);
    Task<ResultModel> GetRequestByYear(StatisticSearchByTimeModel model);
    Task<ResultModel> GetRequest(StatisticSearchModel model);
}

public class StatisticService : IStatisticService
{
    private readonly AppDbContext _dbContext;

    public StatisticService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ResultModel> GetRequestByMonth(StatisticSearchByTimeModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var statistic = new List<StatisticMonthModel>();
            IEnumerable<(int Month, int Year)>? months =
           MonthsBetween(model.StartDate, model.EndDate);

            foreach (var month in months)
            {
                var requestUpgradeCount = _dbContext.RequestUpgrades
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (RequestUpgrade x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Month == month.Month && x.Status == model.RequestStatus || model.RequestStatus == null).Count();
                var requestExpandCount = _dbContext.RequestExpands
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (RequestExpand x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Month == month.Month && x.Status == model.RequestStatus || model.RequestStatus == null).Count();
                var requestHostCount = _dbContext.RequestHosts
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (RequestHost x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Month == month.Month && x.Status.ToString() == model.RequestStatus.ToString() || model.RequestStatus == null).Count();
                var incidentCount = _dbContext.Incidents
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (Incident x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Month == month.Month && x.IsResolved == model.Resolved || model.Resolved == null).Count();
                var appointmentCount = _dbContext.Appointments
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (Appointment x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Month == month.Month && x.Status == model.RequestStatus || model.RequestStatus == null).Count();

                statistic.Add(new StatisticMonthModel
                {
                    Month = month.Month,
                    RequestExpands = requestExpandCount,
                    RequestHosts = requestHostCount,
                    RequestUpgrades = requestUpgradeCount,
                    Incidents = incidentCount,
                    Appointments = appointmentCount,
                });
            }

            result.Succeed = true;
            result.Data = statistic;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetRequestByYear(StatisticSearchByTimeModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var statistic = new List<StatisticYearModel>();
            IEnumerable<int> years = MonthsBetween(model.StartDate, model.EndDate).ToList().Select(x => x.Year);

            foreach (var year in years)
            {
                var requestUpgradeCount = _dbContext.RequestUpgrades
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (RequestUpgrade x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Year == year && x.Status == model.RequestStatus || model.RequestStatus == null).Count();
                var requestExpandCount = _dbContext.RequestExpands
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (RequestExpand x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Year == year && x.Status == model.RequestStatus || model.RequestStatus == null).Count();
                var requestHostCount = _dbContext.RequestHosts
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (RequestHost x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Year == year && x.Status.ToString() == model.RequestStatus.ToString() || model.RequestStatus == null).Count();
                var incidentCount = _dbContext.Incidents
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (Incident x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Year == year && x.IsResolved == model.Resolved || model.Resolved == null).Count();
                var appointmentCount = _dbContext.Appointments
                    .Include(x => x.ServerAllocation)
                    .Where(delegate (Appointment x)
                    {
                        var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                        var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                        return matchCustomer && matchServer;
                    })
                    .Where(x => x.DateCreated.Year == year && x.Status == model.RequestStatus || model.RequestStatus == null).Count();

                statistic.Add(new StatisticYearModel
                {
                    Year = year,
                    RequestExpands = requestExpandCount,
                    RequestHosts = requestHostCount,
                    RequestUpgrades = requestUpgradeCount,
                    Incidents = incidentCount,
                    Appointments = appointmentCount,
                });
            }

            result.Succeed = true;
            result.Data = statistic;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    public async Task<ResultModel> GetRequest(StatisticSearchModel model)
    {

        var result = new ResultModel();
        result.Succeed = false;

        try
        {
            var requestUpgradeCount = _dbContext.RequestUpgrades
                .Include(x => x.ServerAllocation)
                .Where(delegate (RequestUpgrade x)
                {
                    var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                    var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                    return matchCustomer && matchServer;
                }).Count();
            var requestExpandCount = _dbContext.RequestExpands
                .Include(x => x.ServerAllocation)
                .Where(delegate (RequestExpand x)
                {
                    var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                    var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                    return matchCustomer && matchServer;
                }).Count();
            var requestHostCount = _dbContext.RequestHosts
                .Include(x => x.ServerAllocation)
                .Where(delegate (RequestHost x)
                {
                    var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                    var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                    return matchCustomer && matchServer;
                }).Count();
            var incidentCount = _dbContext.Incidents
                .Include(x => x.ServerAllocation)
                .Where(delegate (Incident x)
                {
                    var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                    var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                    return matchCustomer && matchServer;
                }).Count();
            var appointmentCount = _dbContext.Appointments
                .Include(x => x.ServerAllocation)
                .Where(delegate (Appointment x)
                {
                    var matchCustomer = model.CustomerId != null ? x.ServerAllocation.CustomerId == model.CustomerId : true;
                    var matchServer = model.ServerAllocationId != null ? x.ServerAllocationId == model.ServerAllocationId : true;
                    return matchCustomer && matchServer;
                }).Count();

            var statistic = new StatisticModel
            {
                RequestExpands = requestExpandCount,
                RequestHosts = requestHostCount,
                RequestUpgrades = requestUpgradeCount,
                Incidents = incidentCount,
                Appointments = appointmentCount,
            };


            result.Succeed = true;
            result.Data = statistic;
        }
        catch (Exception e)
        {
            result.ErrorMessage = MyFunction.GetErrorMessage(e);
        }

        return result;
    }

    private static IEnumerable<(int Month, int Year)> MonthsBetween(DateTime startDate, DateTime endDate)
    {
        DateTime iterator;
        DateTime limit;

        if (endDate > startDate)
        {
            iterator = new DateTime(startDate.Year, startDate.Month, 1);
            limit = endDate;
        }
        else
        {
            iterator = new DateTime(endDate.Year, endDate.Month, 1);
            limit = startDate;
        }

        var dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
        while (iterator <= limit)
        {
            yield return (
                iterator.Month,
                iterator.Year
            );

            iterator = iterator.AddMonths(1);
        }
    }
}
