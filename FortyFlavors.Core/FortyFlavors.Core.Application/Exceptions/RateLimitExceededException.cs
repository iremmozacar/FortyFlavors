using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class RateLimitExceededException : BaseException
{
    public RateLimitExceededException(string message = "Çok fazla istek gönderildi. Lütfen daha sonra tekrar deneyin.") : base(message, 429)
    {
    }
}
