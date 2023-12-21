using Data.Utils.ValidationAttributes;
using IMS.Data.Utils.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class StatisticModel
{
    public int RequestHosts { get; set; }
    public int RequestUpgrades { get; set; }
    public int RequestExpands { get; set; }
    public int Incidents { get; set; }
    public int Appointments { get; set; }
}

public class StatisticMonthModel
{
    public int Month { get; set; }
    public int RequestHosts { get; set; }
    public int RequestUpgrades { get; set; }
    public int RequestExpands { get; set; }
    public int Incidents { get; set; }
    public int Appointments { get; set; }
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
}

public class StatisticSearchModel
{
    public Guid? CustomerId { get; set; }
    public int? ServerAllocationId { get; set; }
}
