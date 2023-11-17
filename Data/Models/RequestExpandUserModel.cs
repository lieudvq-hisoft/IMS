using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class RequestExpandUserModel
{
    public int Id { get; set; }
    public int RequestExpandId { get; set; }
    public Guid UserId { get; set; }
}

public class RequestExpandUserSearchModel
{
    public int? Id { get; set; } = null;
}