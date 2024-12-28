using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class TimeoutException : BaseException
{
    public TimeoutException(string message = "İşlem zaman aşımına uğradı.") : base(message, 402)
    {
    }
}
