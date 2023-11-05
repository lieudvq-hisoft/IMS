using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models;
public class AppointmentScheduleModel
{
    public int Id { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public string Reason { get; set; }
    public string Note { get; set; }
    public string CompanyName { get; set; }
    public List<string>? ServerId { get; set; }
}

public class AppointmentScheduleDetailModel
{
    public int Id { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public string CompanyName { get; set; }
    public string VisitorName { get; set; }
    public string VisitorPosition { get; set; }
    public string VisitorEmployeedId { get; set; }
    public string Reason { get; set; }
    public string Note { get; set; }
    public List<string>? ServerId { get; set; }

}

