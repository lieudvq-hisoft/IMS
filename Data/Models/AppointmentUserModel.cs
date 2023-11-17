namespace Data.Models;
public class AppointmentUserModel
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
}

public class AppointmentUserSearchModel
{
    public int? Id { get; set; } = null;
}
