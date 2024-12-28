using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class AuthenticationException : BaseException
{
    public AuthenticationException(string message="Kimlik doğrulama başarısız oldu.") : base(message, 404)
    {
    }
}
