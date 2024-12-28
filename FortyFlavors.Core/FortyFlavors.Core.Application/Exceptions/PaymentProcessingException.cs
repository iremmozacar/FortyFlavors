using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class PaymentProcessingException : BaseException
{
    public PaymentProcessingException(string message= "Ödeme işlenirken bir hata oluştu.") : base(message, 500)
    {
    }
}
