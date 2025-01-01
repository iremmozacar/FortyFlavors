using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces;
using FortyFlavors.Core.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

public class GetOrderDetailsQuery : IRequest<OrderDetailsDto>
{
    public int OrderId { get; set; }

    public GetOrderDetailsQuery(int orderId)
    {
        OrderId = orderId;
    }
}

public class GetOrderDetailsQueryHandler : IRequestHandler<GetOrderDetailsQuery, OrderDetailsDto>
{
    private readonly IAppDbContext _context;

    public GetOrderDetailsQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<OrderDetailsDto> Handle(GetOrderDetailsQuery request, CancellationToken cancellationToken)
    {
        var order = await _context.Orders
            .Include(o => o.OrderItems)
            .Where(o => o.Id == request.OrderId)
            .Select(o => new OrderDetailsDto
            {
                Id = o.Id,
                TotalPrice = o.TotalAmount,
                CreatedAt = o.OrderDate,
                Items = o.OrderItems.Select(oi => new OrderItemDto
                {
                    ProductId = oi.ProductId,
                    ProductName = oi.Product.Name,
                    Quantity = oi.Quantity,
                    UnitPrice = oi.UnitPrice,
                    TotalPrice = oi.Quantity * oi.UnitPrice
                }).ToList()
            })
            .FirstOrDefaultAsync(cancellationToken);

        return order;
    }
}