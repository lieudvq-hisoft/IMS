using Microsoft.AspNetCore.Http;

namespace Services.Core;
public interface IFileService
{
    Task<string> SaveFile(IFormFile importFile, string folderPath);
    Task DeleteFile(string filePath);
    Task<string> SaveFileWithGuidName(IFormFile file, string folderPath);
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
        Guid guid = Guid.NewGuid();
        var extension = System.IO.Path.GetExtension(file.FileName);
        string filePath = Path.Combine(folderPath, $"{guid}{extension}");
        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(fileStream);
        }

        return filePath;
    }

    public async Task DeleteFile(string filePath)
    {
        System.IO.File.Delete(filePath);
    }
}
