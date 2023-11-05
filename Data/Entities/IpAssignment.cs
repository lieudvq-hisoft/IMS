using Data.Enums;

namespace Data.Entities;
public class IpAssignment : BaseEntity
{
    public DateTime DateAssign { get; set; }
    public DateTime? DateUnassign { get; set; }
    public IpAssignmentStatus Status { get; set; }
    public IpAssignmentType Type { get; set; }
    //public string? InspectionRecordFilePath { get; set; }

    public int ServerId { get; set; }
    public virtual Server Server { get; set; }

    public int IpId { get; set; }
    public virtual Ip Ip { get; set; }

    public string DisplayStatus()
    {
        string status = string.Empty;
        if (Ip.Blocked)
        {
            status = "Đã chặn";
        }
        else
        {
            switch (Status)
            {
                case (IpAssignmentStatus.Pending):
                    status = "Đang xét duyệt";
                    break;
                case (IpAssignmentStatus.Ongoing):
                    status = "Đang cấp";
                    break;
                case (IpAssignmentStatus.Denied):
                    status = "Bị từ chối";
                    break;
                case (IpAssignmentStatus.Ended):
                    status = "Còn trống";
                    break;
            }
        }

        return status;
    }

    public string DisplayContent()
    {
        string type = string.Empty;
        if (Ip.Blocked)
        {
            type = "Chặn";
        }
        else
        {
            switch (Status)
            {
                case (IpAssignmentStatus.Pending):
                case (IpAssignmentStatus.Ongoing):
                    type = "Cấp mới";
                    break;
                case (IpAssignmentStatus.Ended):
                    type = "Thu hồi";
                    break;
            }
        }

        return type;
    }
}
