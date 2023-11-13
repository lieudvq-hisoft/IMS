﻿using Data.Enums;

namespace Data.Entities;
public class ServerAllocation : BaseEntity
{
    public ServerAllocationStatus Status { get; set; }
    public int ExpectedSize { get; set; }
    public string? Note { get; set; }
    public string? InspectorNote { get; set; }
    public string? InspectionRecordFilePath { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public ICollection<ServerHardwareConfig> ServerHardwareConfigs { get; set; }
    public ICollection<RequestUpgrade> RequestUpgrades { get; set; }
}
