namespace Exercice06.Services;

public class UploadPictureService(IWebHostEnvironment webHost) : IUploadPictureService
{
    public string? Upload(IFormFile file)
    {
        if (file is null or { Length: 0 }) return null;

        var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
        
        var path = Path.Combine(webHost.WebRootPath, "pictures", fileName);
        
        using var fileStream = new FileStream(path, FileMode.Create);
        file.CopyTo(fileStream);

        return Path.Combine("pictures", fileName);
    }
}