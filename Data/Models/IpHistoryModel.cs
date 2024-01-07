using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class IpHistoryModel
{
    public DateTime DateExecuted { get; set; }
    public bool IsBlock { get; set; }
    public string? Reason { get; set; }
    public int CurrentServerId { get; set; }

    public ServerAllocationModel? CurrentServer { get; set; }

    public IpAddressResultModel? IpAddress { get; set; }

    public UserModel? Executor { get; set; }
}
