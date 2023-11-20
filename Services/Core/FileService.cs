using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;

namespace Services.Core;
public interface IFileService
{
    Task<string> SaveFile(IFormFile importFile, string folderPath);
    Task DeleteFile(string filePath);
    Task<string> SaveFileWithGuidName(IFormFile file, string folderPath);
    string GetMimeTypeForFileExtension(string filePath);
}

public class FileService : IFileService
{
    public async Task<string> SaveFile(IFormFile file, string folderPath)
    {
        string filePath = Path.Combine(folderPath, file.FileName);
        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(fileStream);
        }

        return filePath;
    }

    public async Task<string> SaveFileWithGuidName(IFormFile file, string folderPath)
    {
        var extension = System.IO.Path.GetExtension(file.FileName);
        string fileName = $"{Guid.NewGuid()}{extension}";
        string filePath = Path.Combine(folderPath, fileName);
        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(fileStream);
        }

        return fileName;
    }

    public async Task DeleteFile(string filePath)
    {
        System.IO.File.Delete(filePath);
    }

    public string GetMimeTypeForFileExtension(string filePath)
    {
        const string DefaultContentType = "application/octet-stream";

        var provider = new FileExtensionContentTypeProvider();

        if (!provider.TryGetContentType(filePath, out string contentType))
        {
            contentType = DefaultContentType;
        }

        return contentType;
    }
}
