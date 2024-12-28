using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class DependencyException : BaseException
{
    public DependencyException(string message = "Bir bağımlılık hatası oluştu.") : base(message, 500)
    {
    }
}
