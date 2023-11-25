﻿using Data.Enums;
using Data.Utils.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class AppointmentModel
{
    public int Id { get; set; }
    public string AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public string Reason { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public bool IsCorrectPerson { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateUpdated { get; set; } = DateTime.Now;

    public ServerAllocationResultModel? ServerAllocation { get; set; }
    public CustomerResultModel? Customer { get; set; }
    public UserModel? Evaluator { get; set; }
    public UserModel? Executor { get; set; }
}

public class AppointmentResultModel
{
    public int Id { get; set; }
    public string AppointedCustomer { get; set; }
    public DateTime DateAppointed { get; set; }
    public DateTime DateCheckedIn { get; set; }
    public DateTime DateCheckedOut { get; set; }
    public string Reason { get; set; }
    public string? Note { get; set; }
    public string? TechNote { get; set; }
    public bool IsCorrectPerson { get; set; }
    public RequestStatus Status { get; set; }
    public int ServerAllocationId { get; set; }
    public string? InspectionReportFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
}

public class AppointmentCreateModel
{
    [Required]
    public string AppointedCustomer { get; set; }

    [Required]
    public DateTime DateAppointed { get; set; }

    [Required]
    public string Reason { get; set; }

    public string? Note { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }

    public List<int>? RequestUpgradeIds { get; set; }

    public List<int>? RequestExpandIds { get; set; }
    public List<int>? RequestRemovalIds { get; set; }
}

public class RequestAppointmentCreateModel
{
    public List<int>? RequestUpgradeIds { get; set; }

    public List<int>? RequestExpandIds { get; set; }

    public List<int>? RequestRemovalIds { get; set; }
}

public class RequestAppointmentCreateResultModel
{
    public IEnumerable<object> RequestUpgradeAppointments { get; set; }

    public IEnumerable<object> RequestExpandAppointments { get; set; }

    public IEnumerable<object> RequestHostAppointments { get; set; }
}

public class AppointmentCreateResultModel
{
    public AppointmentResultModel Appointment { get; set; }

    public IEnumerable<object> RequestUpgradeAppointments { get; set; }

    public IEnumerable<object> RequestExpandAppointments { get; set; }

    public IEnumerable<object> RequestRemovalAppointments { get; set; }

    public IEnumerable<object> RequestHostAppointments { get; set; }
}

public class AppointmentUpdateModel
{
    [Required]
    [GreaterThanZero]
    public int Id { get; set; }

    [Required]
    public DateTime DateAppointed { get; set; }

    [Required]
    public string Reason { get; set; }

    public string? Note { get; set; }

    [Required]
    [GreaterThanZero]
    public int ServerAllocationId { get; set; }
}

public class AppointmentCompleteModel
{
    [Required]
    public DateTime DateCheckedIn { get; set; }

    [Required]
    public DateTime DateCheckedOut { get; set; }

    public string? TechNote { get; set; }

    [Required]
    public bool IsCorrectPerson { get; set; }
}

public class AppointmentSearchModel
{
    public int? Id { get; set; }
    public RequestStatus? Status { get; set; }
    public int? ServerAllocationId { get; set; }
}

