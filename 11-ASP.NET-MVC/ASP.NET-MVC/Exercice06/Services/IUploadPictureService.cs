﻿namespace Exercice06.Services;

public interface IUploadPictureService
{
    public string? Upload(IFormFile file);
}