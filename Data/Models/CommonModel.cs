using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Data.Models;
public class ResultModel
{
    public string ErrorMessage { get; set; }
    public object Data { get; set; }
    public bool Succeed { get; set; }
    public int Code { get; set; }
}

public class DocumentFileUploadModel
{
    [Required]
    public IFormFile InspectionReport { get; set; }


    [FileExtensions(Extensions = "pdf,docx,doc,jpeg")]
    public string InspectionReportFileName => InspectionReport?.FileName;

    [Required]
    public IFormFile ReceiptOfRecipient { get; set; }


    [FileExtensions(Extensions = "pdf,docx,doc,jpeg")]
    public string ReceiptOfRecipientFileName => ReceiptOfRecipient?.FileName;
}

public class RequestHostDocumentFileUploadModel
{
    [Required]
    public IFormFile InspectionReport { get; set; }


    [FileExtensions(Extensions = "pdf,docx,doc,jpeg")]
    public string InspectionReportFileName => InspectionReport?.FileName;
}

public class DocumentFileResultModel
{
    public string InspectionReport { get; set; }

    public string ReceiptOfRecipient { get; set; }
}

public class RequestAcceptModel
{
    public Guid userId { get; set; }
}

public class RequestHostDocumentFileResultModel
{
    public string InspectionReport { get; set; }
}

public class ExcelFileUploadModel
{
    [Required]
    public IFormFile File { get; set; }

    [FileExtensions(Extensions = "xlsx")]
    public string FileName => File?.FileName;
}
