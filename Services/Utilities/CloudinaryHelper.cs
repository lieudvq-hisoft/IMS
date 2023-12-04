using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Services.Utilities;
public interface ICloudinaryHelper
{
    string UploadFile(IFormFile file);
}

public class CloudinaryHelper : ICloudinaryHelper
{
    private readonly Cloudinary _cloudinary;
    private readonly IConfiguration _config;

    public CloudinaryHelper(IConfiguration config)
    {
        _config = config;
        _cloudinary = new Cloudinary(_config["Cloudinary"]);
        _cloudinary.Api.Secure = true;
    }

    public string UploadFile(IFormFile file)
    {
        var uploadParams = new RawUploadParams()
        {
            File = new FileDescription(file.FileName, file.OpenReadStream()),
        };
        var uploadResult = _cloudinary.Upload(uploadParams);

        //return _cloudinary.DownloadArchiveUrl(uploadResult.PublicId);
        return _cloudinary.Api.UrlImgUp.ResourceType(uploadResult.ResourceType).Version(uploadResult.Version).BuildUrl(uploadResult.PublicId);
    }
}
