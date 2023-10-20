using Data.Enums;

namespace Data.Entities;
public class AdditionalService : BaseEntity
{
    public AdditionalServiceStatus Status { get; set; }

    public int ColocationId { get; set; }
    public virtual Colocation Colocation { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }
}
