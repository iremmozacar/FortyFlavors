using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.Intefaces.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetPaymentsDetailQuery : IRequest<List<PaymentResponseDto>>
{
    public int OrderId { get; set; }

    public GetPaymentsDetailQuery(int orderId)
    {
        OrderId = orderId;
    }
}

public class GetPaymentsDetailQueryHandler : IRequestHandler<GetPaymentsDetailQuery, List<PaymentResponseDto>>
{
    private readonly IAppDbContext _context;

    public GetPaymentsDetailQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PaymentResponseDto>> Handle(GetPaymentsDetailQuery request, CancellationToken cancellationToken)
    {
        var payments = await _context.Payments
            .Where(p => p.OrderId == request.OrderId)
            .Select(p => new PaymentResponseDto
            {
                Amount = p.Amount,
                PaymentDate = p.PaymentDate,
             
            })
            .ToListAsync(cancellationToken);

        return payments;
    }
}