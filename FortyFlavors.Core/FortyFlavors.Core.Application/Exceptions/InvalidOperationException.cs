using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class InvalidOperationException : BaseException
{
    public InvalidOperationException(string message = "İşlem geçerli değil.") : base(message, 400)
    {
    }
}
