using Data.Enums;
using IMS.Data.Utils.ValidationAttributes;

namespace Data.Models;
public class StatisticModel
{
    public StatisticRequestModel RequestHosts { get; set; }
    public StatisticRequestModel RequestUpgrades { get; set; }
    public StatisticRequestModel RequestExpands { get; set; }
    public StatisticIncidentModel Incidents { get; set; }
    public StatisticRequestModel Appointments { get; set; }
}

public class StatisticMonthModel
{
    public int Month { get; set; }
    public int Year { get; set; }
    public StatisticRequestModel RequestHosts { get; set; }
    public StatisticRequestModel RequestUpgrades { get; set; }
    public StatisticRequestModel RequestExpands { get; set; }
    public StatisticIncidentModel Incidents { get; set; }
    public StatisticRequestModel Appointments { get; set; }
}

public class StatisticRequestModel
{
    public int Waiting { get; set; }
    public int Accepted { get; set; }
    public int Success { get; set; }
    public int Denied { get; set; }
    public int Failed { get; set; }
}

public class StatisticIncidentModel
{
    public int Resolved { get; set; }
    public int Unresolved { get; set; }
}

public class StatisticYearModel
{
    public int Year { get; set; }
    public int RequestHosts { get; set; }
    public int RequestUpgrades { get; set; }
    public int RequestExpands { get; set; }
    public int Incidents { get; set; }
    public int Appointments { get; set; }
}

public class StatisticSearchByTimeModel
{
    public Guid? CustomerId { get; set; }
    public int? ServerAllocationId { get; set; }

    [DateLessThan("EndDate", ErrorMessage = "Start date must be sooner than end date")]
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    //public RequestStatus? RequestStatus { get; set; }
    //public bool? Resolved { get; set; }
}

public class StatisticSearchModel
{
    public Guid? CustomerId { get; set; }
    public int? ServerAllocationId { get; set; }
    //public RequestStatus? RequestStatus { get; set; }
    //public bool? Resolved { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
