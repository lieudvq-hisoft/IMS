using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class Role : IdentityRole<Guid>
{
    [Column(TypeName = "varchar(350)")]
    public string Description { get; set; }
    public bool IsDeactived { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; }
}
