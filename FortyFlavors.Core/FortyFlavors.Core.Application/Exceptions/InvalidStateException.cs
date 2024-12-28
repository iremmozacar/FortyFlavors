using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class InvalidStateException : BaseException
{
    public InvalidStateException(string message = "Geçersiz işlem durumu.") : base(message, 400)
    {
    }
}
