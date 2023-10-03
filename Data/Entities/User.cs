﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class User : IdentityUser<Guid>
{
    [Column(TypeName = "varchar(1000)")]
    public string FirstName { get; set; }
    [Column(TypeName = "varchar(1000)")]
    public string? LastName { get; set; }
    public string Address { get; set; }
    public bool isDelete { get; set; }
    public int CurrenNoticeCount { get; set; } = 0;
    public string? FcmToken { get; set; }

    public virtual ICollection<UserRole> UserRoles { get; set; }
}
