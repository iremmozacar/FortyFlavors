using System;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.Intefaces.Common;
using FortyFlavors.Core.Application.Queries.Payments;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Application.Handlers.Queries;

public class GetUserPaymentsQueryHandler : IRequestHandler<GetUserPaymentsQuery, List<PaymentResponseDto>>
{
    private readonly IAppDbContext _context;

    public GetUserPaymentsQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PaymentResponseDto>> Handle(GetUserPaymentsQuery request, CancellationToken cancellationToken)
    {
        var payments = await _context.Payments
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