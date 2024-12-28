using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class SessionExpiredException : BaseException
{
    public SessionExpiredException(string message= "Oturum süresi doldu. Lütfen tekrar giriş yapın.") : base(message, 401)
    {
    }
}
