using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class FileUploadException : BaseException
{
    public FileUploadException(string message = "Dosya yükleme sırasında bir hata oluştu.") : base(message, 400)
    {
    }
}
