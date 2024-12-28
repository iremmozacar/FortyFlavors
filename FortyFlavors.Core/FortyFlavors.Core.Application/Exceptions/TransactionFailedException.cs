using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class TransactionFailedException : BaseException
{
    public TransactionFailedException(string message = "Veritabanı işlemi başarısız oldu.") : base(message, 500)
    {
    }
}
