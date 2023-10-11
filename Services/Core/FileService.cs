using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Core;
public interface IFileService
{
    Task<string> SaveFile(IFormFile importFile, string folderPath);
}

public class FileService: IFileService
{
    public async Task<string> SaveFile(IFormFile importFile, string folderPath)
    {
        string filePath = Path.Combine(folderPath, importFile.FileName);
        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
        {
            await importFile.CopyToAsync(fileStream);
        }

        return filePath;
    }
}
