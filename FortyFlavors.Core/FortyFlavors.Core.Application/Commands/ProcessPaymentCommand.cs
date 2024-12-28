using System;
using MediatR;
namespace FortyFlavors.Core.Application.Commands;

public class ProcessPaymentCommand : IRequest<bool>
{
    public int OrderId { get; set; }       
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string ExpirationDate { get; set; }
    public string CVV { get; set; }

    public ProcessPaymentCommand(int orderId, string cardNumber, string cardHolderName, string expirationDate, string cvv)
    {
        OrderId = orderId;
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpirationDate = expirationDate;
        CVV = cvv;
    }
}
