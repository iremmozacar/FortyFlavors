using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Application.Handlers.Queries
{
    public class GetUserOrdersQuery : IRequest<List<OrderDto>>
    {
        public int UserId { get; set; } // UserId'yi int olarak değiştirdik
        public GetUserOrdersQuery(int userId)
        {
            UserId = userId;
        }
    }

    public class GetUserOrdersQueryHandler : IRequestHandler<GetUserOrdersQuery, List<OrderDto>>
    {
        private readonly IAppDbContext _context;

        public GetUserOrdersQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<List<OrderDto>> Handle(GetUserOrdersQuery request, CancellationToken cancellationToken)
        {
            var orders = await _context.Orders
                .Where(o => o.UserId == request.UserId) // int ile eşleştirme
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
}