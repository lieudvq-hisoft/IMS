using Data.Utils.ValidationAttributes;
using Newtonsoft.Json;
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
    public int CurrenNoticeCount { get; set; }
    public List<string>? Positions { get; set; }
    public List<string>? FcmTokens { get; set; }
}

public class UserViewModel
{
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; }
    public string UserName { get; set; }
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public int CurrenNoticeCount { get; set; }
    public List<string>? Positions { get; set; }
    public List<string>? FcmTokens { get; set; }

}

public class UserAssignModel
{
    [Required]
    public string UserId { get; set; }
}

public class DenyModel
{
    [Required]
    public string SaleNote { get; set; }
}

public class UserCreateModel
{
    [Required]
    public string UserName { get; set; }

    [Required]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$", ErrorMessage = "Password must be atleast 8 character and have lowercase, uppercase and special character")]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Fullname { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string Role { get; set; }
}

public class UserChangePasswordModel
{
    [Required]
    [StringLength(25, MinimumLength = 8, ErrorMessage = "Password must be between 8 to 25 character")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$")]
    public string Password { get; set; }
}

public class UserUpdateModel
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    [StringLength(25, MinimumLength = 8, ErrorMessage = "Password must be between 8 to 25 character")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,}$")]
    public string? Password { get; set; }

    //[Required]
    //[EmailAddress]
    //public string Email { get; set; }

    //[Required]
    //public string Fullname { get; set; }

    //[Required]
    //public string Address { get; set; }

    //[Required]
    //public string PhoneNumber { get; set; }
}

public class LoginModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}

public class UserSearchModel
{
    public string? SearchValue { get; set; } = "";
}

public class BindFcmtokenModel
{
    public string FcmToken { get; set; }
}

public class DeleteFcmtokenModel
{
    public string FcmToken { get; set; }
}
