using System;

namespace FortyFlavors.Core.Application.DTOs.ResponseDto;

public class PaymentRequestDto
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string ExpirationDate { get; set; } 
    public string Cvv { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; } 
    public string Description { get; set; } 
}