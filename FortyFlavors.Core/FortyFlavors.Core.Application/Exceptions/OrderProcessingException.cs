using System;

namespace FortyFlavors.Core.Application.Exceptions;

public class OrderProcessingException : BaseException
{
    public OrderProcessingException(string message= "Sipariş işlenirken bir hata oluştu.") : base(message, 500)
    {
    }
}
