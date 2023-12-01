﻿using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class CustomerModel
{
    public int Id { get; set; }
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
    public string? TaxNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? CustomerName { get; set; }

    //public int? CompanyTypeId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;

    public CompanyTypeModel CompanyType { get; set; }
}

public class CustomerResultModel
{
    public int Id { get; set; }
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
    public string? TaxNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? CustomerName { get; set; }

    //public int? CompanyTypeId { get; set; }
}

public class CustomerCreateModel
{
    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}$|^\d{13}$", ErrorMessage = "Tax number must be a string of 10 or 13 number")]
    public string TaxNumber { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be a string of 10 number")]
    public string PhoneNumber { get; set; }

    //[Required]
    //public int CompanyTypeId { get; set; }
}

public class CustomerUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    [RegularExpression(@"^\d{10}$|^\d{13}$", ErrorMessage = "Tax number must be a string of 10 or 13 number")]
    public string TaxNumber { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [Phone]
    public string PhoneNumber { get; set; }

    //[Required]
    //public int CompanyTypeId { get; set; }
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
    public string? CustomerName { get; set; } = "";
}

public class CustomerLoginModel
{
    public string Email { get; set; }

    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")]
    public string Password { get; set; }
}
