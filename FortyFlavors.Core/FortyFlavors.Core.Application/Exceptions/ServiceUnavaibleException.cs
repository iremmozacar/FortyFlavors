using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class ServiceUnavaibleException : BaseException
{
    public ServiceUnavaibleException(string message= "Servis geçici olarak kullanılamıyor.") : base(message, 503)
    {
    }
}
