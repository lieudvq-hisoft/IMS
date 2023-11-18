using Data.Entities.Pending;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class User : IdentityUser<Guid>
{
    [Column(TypeName = "varchar(1000)")]
    public string Fullname { get; set; }
    public string Address { get; set; }
    public int CurrenNoticeCount { get; set; } = 0;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }

    public ICollection<RequestUpgradeUser> RequestUpgradeUsers { get; set; }
    public ICollection<AppointmentUser> AppointmentUsers { get; set; }
    public ICollection<RequestExpandUser> RequestExpandUsers { get; set; }
    public ICollection<RequestHostUser> RequestHostUsers { get; set; }
}
