using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class OrderValidationException : BaseException
{
    public OrderValidationException(string message = "Sipariş doğrulama sırasında bir hata oluştu.") : base(message, 400)
    {
    }
}
