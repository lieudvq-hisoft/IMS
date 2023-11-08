namespace Data.Models;
public class DeviceModel
{
    public int Id { get; set; }
    public string Type { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdate { get; set; }
    public string Status { get; set; }
    public int BasePower { get; set; }
    public int BaseSize { get; set; }
    public string Rack { get; set; }
}
