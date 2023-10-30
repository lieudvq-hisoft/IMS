using AutoMapper.Configuration.Conventions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Models;
public class AdditionalServiceModel
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
