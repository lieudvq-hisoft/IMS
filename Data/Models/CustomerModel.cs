using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class CustomerModel
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string? CompanyName { get; set; }
    public string? Address { get; set; }
    public string? TaxNumber { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? CustomerName { get; set; }

    public int? CompanyTypeId { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
}

public class CustomerCreateModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string TaxNumber { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; }

    [Phone]
    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string CustomerName { get; set; }

    [Required]
    public int CompanyTypeId { get; set; }
}

public class CustomerUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string CompanyName { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string TaxNumber { get; set; }

    [EmailAddress]
    [Required]
    public string Email { get; set; }

    [Phone]
    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string CustomerName { get; set; }

    [Required]
    public int CompanyTypeId { get; set; }
}

public class CustomerSearchModel
{
    public string? CustomerName { get; set; } = "";
}
