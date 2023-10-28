using Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;
public class AdditionalService : BaseEntity
{
    public AdditionalServiceStatus Status { get; set; }
    public string? InspectionRecordFilePath { get; set; }

    public int? ApproverId { get; set; }
    public virtual Approver? Approver { get; set; }

    public int? ExecuterId { get; set; }
    public virtual Executer? Executer { get; set; }

    public int ColocationId { get; set; }
    public virtual Colocation Colocation { get; set; }

    public int ServiceId { get; set; }
    public virtual Service Service { get; set; }
}
