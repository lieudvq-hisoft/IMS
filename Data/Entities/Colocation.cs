using Data.Enums;

namespace Data.Entities;
public class Colocation : BaseEntity
{
    public ColocationStatus Status { get; set; }
    public int ExpectedSize { get; set; }
    public string? Note { get; set; }
    public string? InspectorNote { get; set; }
    public DateTime DateAllocate { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public int? ServerId { get; set; }
    public virtual Server? Server { get; set; }

    public virtual ICollection<ColocationHistory> ColocationHistories { get; set; }

    public virtual ICollection<AdditionalService> AdditionalServices { get; set; }

    public string GetColocationRequestType()
    {
        ColocationRequestType type;
        if (Status != ColocationStatus.Ongoing && Status != ColocationStatus.Stopped)
        {
            if (AdditionalServices.Any(x => x.Status != AdditionalServiceStatus.Success))
            {
                type = ColocationRequestType.Mixed;
            }
            else
            {
                type = ColocationRequestType.New;
            }
        }
        else
        {
            type = ColocationRequestType.Additional;
        }

        return type.ToString();
    }

    public string GetColocationRequestStatus()
    {
        string status;
        if (Status != ColocationStatus.Ongoing && Status != ColocationStatus.Stopped)
        {
            status = Status.ToString();
        }
        else
        {
            var services = AdditionalServices;
            if (services.All(x => x.Status == AdditionalServiceStatus.Success))
            {
                status = "Accepted";
            }
            else if (services.All(x => x.Status == AdditionalServiceStatus.Denied))
            {
                status = "Denied";
            }
            else if (services.All(x => x.Status == AdditionalServiceStatus.Pending))
            {
                status = "Pending";
            }
            else
            {
                status = "Mixed";
            }
        }

        return status;
    }
}
