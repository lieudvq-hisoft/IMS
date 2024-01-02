using Data.DataAccess.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities;
public class Contact: BaseEntity
{
    public string? Name { get; set; }

    public string? Position { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? CCCD { get; set; }

    public bool ForAppointment { get; set; }

    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}
