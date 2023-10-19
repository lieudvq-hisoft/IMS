using Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class ServerModel
{
}

public class ServerCreateModel
{
    [Required]
    public string Type { get; set; }
    [Required]
    public int NumberOfPort { get; set; }
    [Required]
    public int Size { get; set; }
    [Required]
    public int BasePower { get; set; }
    [Required]
    public string SerialNumber { get; set; }
    [Required]
    public string Model { get; set; }
}
