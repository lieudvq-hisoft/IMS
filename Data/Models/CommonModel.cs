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
    public IFormFile File { get; set; }


    [FileExtensions(Extensions = "pdf,docx")]
    public string FileName => File?.FileName;
}

public class ExcelFileUploadModel
{
    [Required]
    public IFormFile File { get; set; }

    [FileExtensions(Extensions = "xlsx")]
    public string FileName => File?.FileName;
}


