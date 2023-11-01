using Data.Enums;

namespace Data.Entities;
public class Request : BaseEntity
{
    public RequestStatus Status { get; set; }
    public int ExpectedSize { get; set; }
    public string? Note { get; set; }
    public string? InspectorNote { get; set; }
    public DateTime DateAllocate { get; set; }
    public DateTime InitialDateStop { get; set; }
    public DateTime DateStop { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer Customer { get; set; }

    public int? ServerId { get; set; }
    public virtual Server? Server { get; set; }

    public virtual ICollection<RequestExtendHistory> RequestExtendHistories { get; set; }

    public virtual ICollection<ServiceRequest> ServiceRequests { get; set; }

    public string GetRequestType()
    {
        RequestType type;
        if (Status != RequestStatus.Ongoing && Status != RequestStatus.Stopped)
        {
            if (ServiceRequests.Any(x => x.Status != ServiceRequestStatus.Success))
            {
                type = RequestType.Mixed;
            }
            else
            {
                type = RequestType.New;
            }
        }
        else
        {
            type = RequestType.Additional;
        }

        return type.ToString();
    }

    public string GetRequestStatus()
    {
        string status;
        if (Status != RequestStatus.Ongoing && Status != RequestStatus.Stopped)
        {
            status = Status.ToString();
        }
        else
        {
            var services = ServiceRequests;
            if (services.All(x => x.Status == ServiceRequestStatus.Success))
            {
                status = "Accepted";
            }
            else if (services.All(x => x.Status == ServiceRequestStatus.Denied))
            {
                status = "Denied";
            }
            else if (services.All(x => x.Status == ServiceRequestStatus.Pending))
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
