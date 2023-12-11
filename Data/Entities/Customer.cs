using Data.Models;
using Data.Utils.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class Customer
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string TaxNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int CurrenNoticeCount { get; set; } = 0;
    public List<string>? FcmTokens { get; set; } = new List<string>();
    //public string CustomerName { get; set; }

    //public int CompanyTypeId { get; set; }
    //public CompanyType CompanyType { get; set; }

    public ICollection<ServerAllocation> ServerAllocations { get; set; }
    public ICollection<UserCustomer> UserCustomers { get; set; }

    public bool Filter(CustomerSearchModel searchModel)
    {
        var matchCompanyName = searchModel.CompanyName != null ? MyFunction.MatchString(searchModel.CompanyName, CompanyName) : true;
        var isDeleted = searchModel.IsDeleted != null ? IsDeleted == searchModel.IsDeleted : !IsDeleted;
        return matchCompanyName && isDeleted;
    }
}