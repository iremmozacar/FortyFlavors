using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class ResourceConflitException : BaseException
{
    public ResourceConflitException(string resourceName, object conflictValue)
            : base($"{resourceName} değeri '{conflictValue}' zaten mevcut.", 409)
    {
    }
}
