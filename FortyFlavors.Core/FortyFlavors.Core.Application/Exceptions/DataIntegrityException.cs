using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class DataIntegrithyException : BaseException
{
    public DataIntegrithyException(string message = "Veri bütünlüğü ihlali.") : base(message, 422)
    {
    }
}
