using System;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.DTOs.ResponseDto;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IPaymentService
{
    Task<PaymentResponseDto> ProcessPaymentAsync(PaymentRequestDto paymentRequestDto);
    Task<RefundResponseDto> RefundPaymentAsync(string transactionId);
}