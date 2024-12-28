using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class AuthorizationException : BaseException
{
    public AuthorizationException(string message="Bu işlemi gerçekleştirmek için yetkiniz yok.") : base(message, 403)
    {
    }
}
