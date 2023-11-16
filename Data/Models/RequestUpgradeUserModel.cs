using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestUpgradeUserModel
{
    public int Id { get; set; }
    public Guid UserId { get; set; }
    public int RequestUpgradeId { get; set; }
}

public class RequestUpgradeUserSearchModel
{
    public int? Id { get; set; } = null;    
}

