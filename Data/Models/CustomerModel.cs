using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class CustomerModel
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string CompanyRepresentative { get; set; }
    public string TaxNumber { get; set; }
    public Guid UserId { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}

public class CustomerSearchModel
{
    public string? SearchValue { get; set; } = "";
}
