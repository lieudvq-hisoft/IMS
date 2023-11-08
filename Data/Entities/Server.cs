using Data.Enums;

namespace Data.Entities;

public class Server : BaseEntity
{
    public string SerialNumber { get; set; }
    public string Model { get; set; }
    public int NumberOfPort { get; set; }
    public int AdditionalNumberOfPort { get; set; }

    public int DeviceId { get; set; }
    public virtual Device Device { get; set; }

    public virtual ICollection<IpAssignment> IpAssignments { get; set; }

    public virtual ICollection<ServerAppointment> ServerAppointments { get; set; }

    public virtual Request Request { get; set; }

    public string DisplayStatus()
    {
        switch (Request.Status)
        {
            case (RequestStatus.Accepted):
                return "Đang hoạt động";
            case (RequestStatus.Ended):
                return "Ngừng hoạt động";
            case (RequestStatus.Stopped):
                return "Tạm ngừng";
            default:
                throw new Exception("Unaccepted Request");
        }
    }
}
