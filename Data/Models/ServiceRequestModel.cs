namespace Data.Models;
public class ServiceRequestModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public int Quantity { get; set; }
    public string? InspectionRecordFilePath { get; set; }
}

public class ServiceRequestDetailModel
{
    public int Id { get; set; }
    public int Name { get; set; }
    public string Status { get; set; }
    public int Quantity { get; set; }
    public string? Executor { get; set; }
    public string? Approver { get; set; }
    public string Customer { get; set; }
    public string? ReceiptOfRecipientFilePath { get; set; }
}
