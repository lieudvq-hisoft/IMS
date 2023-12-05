using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ServerAllocationModel
{
    public int Id { get; set; }
    public ServerAllocationStatus Status { get; set; }
    public int Power { get; set; }
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public IpAddressResultModel? MasterIp { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public int CustomerId { get; set; }
    public string Location { get; set; }
    public int IpCount { get; set; }
    public CustomerModel? Customer { get; set; }
}

public class ServerAllocationResultModel
{
    public int Id { get; set; }
    public ServerAllocationStatus Status { get; set; }
    public int Power { get; set; }
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public string? MasterIpAddress { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public string? SaleNote { get; set; }
    public string? ServerLocation { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    public int CustomerId { get; set; }
}

public class ServerAllocationAssignLocationModel
{
    [Required]
    [GreaterThanZero]
    public int RackId { get; set; }

    [Required]
    [NotNegative]
    public int StartPosition { get; set; }

    [Required]
    [GreaterThanZero]
    public int Size { get; set; }
}

public class ServerAllocationCreateModel
{
    [Required]
    [StringLength(255, MinimumLength = 6)]
    public string Name { get; set; }

    [StringLength(255, MinimumLength = 6)]
    public string? SerialNumber { get; set; }

    [Range(100, double.MaxValue)]
    public int? Power { get; set; }

    public string? Note { get; set; }

    public string? TechNote { get; set; }

    public string? SaleNote { get; set; }

    [Required]
    public int CustomerId { get; set; }
}

public class ServerAllocationUpdateModel
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Power { get; set; }

    public string? Note { get; set; }

    public string? TechNote { get; set; }
}

public class ServerAllocationMasterIpAssignmentModel
{
    [Required]
    public int IpAddressId { get; set; }
}

public class ServerAllocationSearchModel
{
    public int? CustomerId { get; set; }
    public List<ServerAllocationStatus>? Status { get; set; }
}

public class ServerAllocationImportModel
{
    [Required]
    public CustomerCreateModel CustomerCreateModel { get; set; }

    [Required]
    public ServerAllocationCreateModel RequestCreateModel { get; set; }
}

public class MainDocModel
{
    //[Required]
    public string CustomerName { get; set; } = "CustomerName";

    //[Required]
    public string CustomerPosition { get; set; } = "CustomerPosition";

    //[Required]
    public bool NewAllocation { get; set; } = true;

    //[Required]
    [Url]
    public string Website { get; set; } = "https://superuser.com/questions/278260/how-do-i-see-the-xml-of-my-docx-document";

    //[Required]
    public string Username { get; set; } = "Username";

    //[Required]
    public string Password { get; set; } = "Password";

    //[Required]
    public bool Good { get; set; } = true;

    public string Note { get; set; } = "Note";
}