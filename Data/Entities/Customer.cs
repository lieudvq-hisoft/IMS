using Data.Models;
using Data.Utils.Common;

namespace Data.Entities;

public class Customer : BaseEntity
{
    public string Password { get; set; }
    public string CompanyName { get; set; }
    public string Address { get; set; }
    public string TaxNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
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