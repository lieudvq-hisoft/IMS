using Data.Enums;
using Data.Models;
using Data.Utils.Common;

namespace Data.Entities;
public class Appointment : BaseEntity
{
    public string? AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public AppointmentReason? Reason { get; set; }
    public string? Note { get; set; }
    public string? SaleNote { get; set; }
    public string? TechNote { get; set; }
    public RequestStatus Status { get; set; }
    public bool DocumentConfirm { get; set; }
    public DateTime? DateConfirm { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? FinalInspectionReport { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public string? FinalReceiptOfRecipient { get; set; }

    public int ServerAllocationId { get; set; }
    public ServerAllocation? ServerAllocation { get; set; }

    public ICollection<RequestUpgradeAppointment>? RequestUpgradeAppointment { get; set; }
    public ICollection<AppointmentUser>? AppointmentUsers { get; set; }
    public ICollection<RequestExpandAppointment>? RequestExpandAppointments { get; set; }
    public ICollection<IncidentAppointment>? IncidentAppointments { get; set; }

    public bool FilterAppointment(AppointmentSearchModel searchModel)
    {
        var matchSearchValue = (MyFunction.ConvertToUnSign(AppointedCustomer ?? "").IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0)
            || (MyFunction.ConvertToUnSign(ServerAllocation.Name ?? "").IndexOf(MyFunction.ConvertToUnSign(searchModel.SearchValue ?? ""), StringComparison.CurrentCultureIgnoreCase) >= 0);

        bool matchId = searchModel.Id != null ? Id == searchModel.Id : true;
        bool matchStatus = searchModel.Statuses != null ? searchModel.Statuses.Contains(Status) : true;
        bool matchReason = searchModel.Reasons != null ? searchModel.Reasons.Contains(Reason) : true;
        bool matchServerAllocationId = searchModel.ServerAllocationId != null ? ServerAllocationId == searchModel.ServerAllocationId : true;
        bool matchCustomer = searchModel.CustomerId != null ? ServerAllocation.CustomerId == searchModel.CustomerId : true;
        bool matchUser = searchModel.UserId != null ? AppointmentUsers.Any(x => x.UserId == searchModel.UserId) : true;

        return matchSearchValue && matchId && matchStatus && matchReason && matchServerAllocationId && matchCustomer && matchUser;
    }
}
