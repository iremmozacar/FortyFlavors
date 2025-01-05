using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetOrdersByStatusQuery : IRequest<List<OrderDto>>
{
    public string Status { get; set; }

    public GetOrdersByStatusQuery(string status)
    {
        Status = status;
    }
}

public class GetOrdersByStatusQueryHandler : IRequestHandler<GetOrdersByStatusQuery, List<OrderDto>>
{
    private readonly IAppDbContext _context;

    public GetOrdersByStatusQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<List<OrderDto>> Handle(GetOrdersByStatusQuery request, CancellationToken cancellationToken)
    {
        var orders = await _context.Orders
            .Where(o => o.Status == request.Status)
            .Select(o => new OrderDto
            {
                Id = o.Id,
                Status = o.Status,
                TotalPrice = o.TotalAmount,
                CreatedAt = o.OrderDate
            })
            .ToListAsync(cancellationToken);

        return orders;
    }
}