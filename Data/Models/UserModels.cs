﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class UserModel
{
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; }
    public string UserName { get; set; }
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}

public class UserViewModel
{
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; }
    public string UserName { get; set; }
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}

public class UserAssignModel
{
    [Required]
    public string UserId { get; set; }
}

public class UserRoleModel
{
    public RoleModel role { get; set; }
}

public class UserCreateModel
{
    [Required]
    public string UserName { get; set; }

    [Required]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$", ErrorMessage = "Password must be atleast 8 character and have lowercase, uppercase and special character")]
    public string Password { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Fullname { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public List<string> Roles { get; set; }
}

public class UserUpdateModel
{
    [Required]
    public Guid Id { get; set; }

    //[Required]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$")]
    public string? Password { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Fullname { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string PhoneNumber { get; set; }
}


public class LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}

public class AssignRoleModel
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
    public bool isAssign { get; set; }
}

public class UserSearchModel
{
    public string? SearchValue { get; set; } = "";
}