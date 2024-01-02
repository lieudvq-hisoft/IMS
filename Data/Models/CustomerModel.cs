using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class CustomerModel
{
    public Guid Id { get; set; }
    public string? Representator { get; set; }
    public string? RepresentatorPosition { get; set; }
    public string? ContractNumber { get; set; }
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
    public string? TaxNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public bool IsDeleted { get; set; }
    public List<ContactModel>? Contacts { get; set; }
    public int CurrenNoticeCount { get; set; }
    public List<string>? FcmTokens { get; set; }
    public Guid? SaleStaff { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class CustomerResultModel
{
    public Guid Id { get; set; }
    public string? Representator { get; set; }
    public string? RepresentatorPosition { get; set; }
    public string? ContractNumber { get; set; }
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
    public string? TaxNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public Guid? SaleStaff { get; set; }
    public List<ContactModel>? Contacts { get; set; }
    public int CurrenNoticeCount { get; set; }
    public List<string>? FcmTokens { get; set; }
}

public class ContactModel
{
    [Required]
    public string? Name { get; set; }

    [Required]
    public bool ForAppointment { get; set; }

    public string? Position { get; set; }

    [RegularExpression(@"^\d{10}$|^\d{11}$", ErrorMessage = "Phone number must be a string of 10 or 11 number")]
    public string? PhoneNumber { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
}

public class CustomerCreateModel
{
    [Required]
    public string Representator { get; set; }

    [Required]
    public string RepresentatorPosition { get; set; }

    [Required]
    [RegularExpression(@"^\d+$")]
    public string ContractNumber { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}(-\d{3,4})?$", ErrorMessage = "Tax number must be a string of 10 or 13 number")]
    public string TaxNumber { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}$|^\d{11}$", ErrorMessage = "Phone number must be a string of 10 or 11 number")]
    public string PhoneNumber { get; set; }

    public List<ContactModel>? Contacts { get; set; }
}

public class CustomerUpdateModel
{
    [Required]
    public string Id { get; set; }

    [Required]
    public string Representator { get; set; }

    [Required]
    public string RepresentatorPosition { get; set; }

    [Required]
    [RegularExpression(@"^\d+$")]
    public string ContractNumber { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}(-\d{3,4})?$", ErrorMessage = "Tax number must be a string of 10 or 13 number")]
    public string TaxNumber { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}$|^\d{11}$", ErrorMessage = "Phone number must be a string of 10 or 11 number")]
    public string PhoneNumber { get; set; }

    public List<ContactModel>? Contacts { get; set; }
}

public class CustomerChangePasswordModel
{
    [Required]
    [DataType(DataType.Password)]
    public string CurrentPassword { get; set; }

    [Required]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must be at least 8 character with lower, upper and special character and number")]
    public string Password { get; set; }
}

public class CustomerSearchModel
{
    public string? CompanyName { get; set; }
    public bool? IsDeleted { get; set; }
}

public class CustomerLoginModel
{
    public string Email { get; set; }

    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")]
    public string Password { get; set; }
}
