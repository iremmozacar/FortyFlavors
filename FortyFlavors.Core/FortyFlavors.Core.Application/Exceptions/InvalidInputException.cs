using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class InvalidInputException : BaseException
{
    public InvalidInputException(string message = "Geçersiz giriş sağlandı.") : base(message, 422)
    {
    }
}
