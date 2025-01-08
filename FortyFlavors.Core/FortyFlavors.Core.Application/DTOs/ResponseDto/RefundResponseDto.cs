using System;

namespace FortyFlavors.Core.Application.DTOs.ResponseDto;

public class RefundResponseDto
{
    public string TransactionId { get; set; }
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public DateTime RefundDate { get; set; }
}