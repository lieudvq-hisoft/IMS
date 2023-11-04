using Data.Enums;

namespace Data.Entities;

public class Device : BaseEntity
{
    public string Type { get; set; }
    public int Size { get; set; }
    public int AdditionalSize { get; set; }
    public int BasePower { get; set; }
    public int AdditionalPower { get; set; }
    public DeviceStatus DeviceStatus { get; set; }

    public virtual Server? Server { get; set; }

    public virtual ICollection<Location> Locations { get; set; }

    public string DisplayStatus()
    {
        switch (DeviceStatus)
        {
            case (DeviceStatus.Ongoing):
                return "Đang hoạt động";
            case (DeviceStatus.Ended):
                return "Ngừng hoạt động";
            case (DeviceStatus.Stopped):
                return "Tạm ngừng";
            default:
                throw new Exception("Unaccepted Request");
        }
    }
}
