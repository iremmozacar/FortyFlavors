using System;

namespace FortyFlavors.Core.Application.DTOs;

public class ProcessPaymentDto
{
    public int OrderId { get; set; }
    public string PaymentMethod { get; set; }
    public decimal Amount { get; set; }
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string ExpiryDate { get; set; }
    public string Cvc { get; set; }
}
