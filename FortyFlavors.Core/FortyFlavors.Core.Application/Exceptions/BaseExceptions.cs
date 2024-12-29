using System;

namespace FortyFlavors.Core.Application.Exceptions;

public abstract class BaseException:Exception
{
    public int StatusCode { get; }

    protected BaseException(string message, int errorCode) : base(message)
    {
        StatusCode = StatusCode;
    }
}
