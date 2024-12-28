using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class PaymentDeclinedException : BaseException
{
    public PaymentDeclinedException(string message  = "Ödeme reddedildi.") : base(message, 402)
    {
    }
}
