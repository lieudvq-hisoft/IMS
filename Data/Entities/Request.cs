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

    public int? TechExecutionId { get; set; }
    public virtual TechExecution? TechExecution { get; set; }

    public int? SaleApprovalId { get; set; }
    public virtual SaleApproval? SaleApproval { get; set; }

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
        string status = string.Empty;
        switch (Status)
        {
            case RequestStatus.Ongoing:
                status = "Đang hoạt động";
                break;
            case RequestStatus.Stopped:
                status = "Tạm ngừng";
                break;
            case RequestStatus.Incomplete:
                status = "Chưa hoàn thiện";
                break;
            case RequestStatus.Pending:
                status = "Chờ xét duyệt";
                break;
            case RequestStatus.Accepted:
                status = "Thành công";
                break;
            case RequestStatus.Denied:
                status = "Không thành công";
                break;
            case RequestStatus.Ended:
                status = "Kết thúc";
                break;
        }

        return status;
    }
}
