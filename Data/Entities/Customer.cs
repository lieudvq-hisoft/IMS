using Data.Models;
using Data.Utils.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

public class Customer
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;
    public DateTime? DateContract { get; set; }
    public bool IsDeleted { get; set; }
    public string Representator { get; set; }
    public string RepresentatorPosition { get; set; }
    public string ContractNumber { get; set; }
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string TaxNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int CurrenNoticeCount { get; set; } = 0;
    public Guid? SaleStaff { get; set; }
    public List<string>? FcmTokens { get; set; } = new List<string>();

    public ICollection<ServerAllocation> ServerAllocations { get; set; }
    public ICollection<UserCustomer> UserCustomers { get; set; }
    public ICollection<Contact> Contacts { get; set; }

    public bool Filter(CustomerSearchModel searchModel)
    {
        var matchCompanyName = searchModel.CompanyName != null ? MyFunction.MatchString(searchModel.CompanyName, CompanyName) : true;
        var isDeleted = searchModel.IsDeleted != null ? IsDeleted == searchModel.IsDeleted : !IsDeleted;
        var matchSale = UserCustomers.FirstOrDefault(x => x.UserId == searchModel.SaleId) != null || searchModel.SaleId == null;
        return matchCompanyName && isDeleted && matchSale;
    }
}