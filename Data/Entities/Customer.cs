using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;

public class Customer : BaseEntity
{
    public string CompanyName { get; set; }
    public string CompanyRepresentative { get; set; }
    public string PhoneNumber { get; set; }
    public string TaxNumber { get; set; }
    //public string Model { get; set; }
    //public string SerialNumber { get; set; }
    //public string Power { get; set; }
    //public DateTime StartAllocationDate { get; set; }
    //public DateTime StopAllocationDate { get; set; }
    public Guid User_Id { get; set; }
    public virtual required User User { get; set; }
}
