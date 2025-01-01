using System;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Application.DTOs;


    public class PaymentResponseDto
    {
        public int Id { get; internal set; }
        public int OrderId { get; internal set; }
        public DateTime PaymentDate { get; internal set; }
        public decimal Amount { get; internal set; }
        public string PaymentStatus { get; internal set; }
        public int UserId { get; internal set; }
    

    public PaymentResponseDto(int id, int orderId, DateTime paymentDate, decimal amount, string paymentStatus, int userId)
    {
        Id = id;
        OrderId = orderId;
        PaymentDate = paymentDate;
        Amount = amount;
        PaymentStatus = paymentStatus;
        UserId = userId;
    }


public async Task<List<PaymentResponseDto>> Handle(GetUserPaymentQuery request, CancellationToken cancellationToken)
    {
        var payments = await DbContext.Payments
            .Where(p => p.UserId == request.UserId)
            .Select(p => new PaymentResponseDto(
                p.Id,
                p.OrderId,
                p.PaymentDate,
                p.Amount,
                p.PaymentStatus,
                p.UserId
            ))
            .ToListAsync(cancellationToken);

        return payments;
    }
}