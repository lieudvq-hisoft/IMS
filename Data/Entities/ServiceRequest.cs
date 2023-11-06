﻿using Data.Enums;

namespace Data.Entities;
public class ServiceRequest : BaseEntity
{
    public int Quantity { get; set; }
    public ServiceRequestStatus Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public bool IsDelegated { get; set; }

    public int RequestId { get; set; }
    public virtual Request Request { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }

    public int? SaleApprovalId { get; set; }
    public virtual SaleApproval? SaleApproval { get; set; }

    public int? TechExecutionId { get; set; }
    public virtual TechExecution? TechExecution { get; set; }

    public int? IpId { get; set; }
    public virtual Ip? Ip { get; set; }

    public string DisplayStatus()
    {
        string status = string.Empty;
        switch (Status)
        {
            case ServiceRequestStatus.Pending:
                status = "Chờ xét duyệt";
                break;
            case ServiceRequestStatus.Accepted:
                status = "Thành công";
                break;
            case ServiceRequestStatus.Denied:
                status = "Không thành công";
                break;
            case ServiceRequestStatus.Success:
                status = "Đang hoạt động";
                break;
        }

        return status;
    }
}
