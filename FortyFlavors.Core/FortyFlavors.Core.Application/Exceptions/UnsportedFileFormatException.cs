using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class UnsportedFileFormatException : BaseException
{
    public UnsportedFileFormatException(string message = "Desteklenmeyen bir dosya türü yüklendi.") : base(message, 415)
    {
    }
}
