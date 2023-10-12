using Data.Enums;
using IMS.Data.Utils.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class CollocationModel
{
    public int Id { get; set; }
    public DateTime DateCreate { get; set; }
    public string CompanyName { get; set; }
    public CollocationStatus Status { get; set; }
}

public class CollocationCreateModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public DateTime DateCreate { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateCreate", ErrorMessage = "Allocate dat must be later than create date")]
    public DateTime DateAllocate { get; set; }

    [Required]
    [DateMoreThan(comparisonProperty: "DateAllocate", ErrorMessage = "Stop dat must be later than allocate date")]
    public DateTime DateStop { get; set; }

    public string? Note { get; set; }

    public string? InspectorNote { get; set; }

    public List<AdditionalServiceModel> AdditionalServices { get; set; }
}

public class CollocationUpdateModel
{
    [Required]
    public int CollocationId { get; set; }

    [Required]
    public string Model { get; set; }

    [Required]
    public int Size { get; set; }

    [Required]
    public int NumberOfPort { get; set; }

    public int SerialNumber { get; set; }

    public int BasePower { get; set; }

    public int LocationId { get; set; }

    public string IpServer { get; set; }

    public string SubnetMask { get; set; }

    public string Gateway { get; set; }

    public string DNS { get; set; }

    public int PortIP { get; set; }
}

public class CollocationSearchModel
{
    public string? SearchValue { get; set; } = "";
}
