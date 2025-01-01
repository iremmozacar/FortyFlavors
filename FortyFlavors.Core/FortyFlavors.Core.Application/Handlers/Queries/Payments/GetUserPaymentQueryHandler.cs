using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.Interfaces;
using MediatR;

public class GetUserPaymentQuery : IRequest<List<PaymentResponseDto>>
{
    public int UserId { get; set; }

    public GetUserPaymentQuery(int userId)
    {
        UserId = userId;
    }
}

public class GetUserPaymentQueryHandler : IRequestHandler<GetUserPaymentQuery, List<PaymentResponseDto>>
{
    private readonly IAppDbContext _context;

    public GetUserPaymentQueryHandler(IAppDbContext context)
    {
        _context = context;
    }
    public async Task<List<PaymentResponseDto>> Handle(GetUserPaymentQuery request, CancellationToken cancellationToken)
    {
        var payments = await _context.Payments
            .Where(p => p.UserId == request.UserId)
            .Select(p => new PaymentResponseDto
            {
                Id = p.Id,
                OrderId = p.OrderId,
                Amount = p.Amount,
                PaymentDate = p.PaymentDate,
                PaymentStatus = p.PaymentStatus,
                UserId = p.UserId 
            })
            .ToListAsync(cancellationToken);

        return payments;
    }
}