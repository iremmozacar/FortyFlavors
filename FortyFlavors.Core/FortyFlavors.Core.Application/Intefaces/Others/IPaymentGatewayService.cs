using System;

namespace FortyFlavors.Core.Application.Intefaces.Infrastructure;

public interface IPaymentGatewayService
{
    bool ProcessPayment(decimal amount, string cardNumber, string expiry, string cvv);
    bool RefundPayment(string transactionId);
}
