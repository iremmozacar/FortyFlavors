using System.Threading;
using System.Threading.Tasks;
using FortyFlavors.Core.Application.Interfaces;
using FortyFlavors.Core.Domain.Entities;
using MediatR;

namespace FortyFlavors.Core.Application.Commands.Orders
{
    public class CreateOrderCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
    {
        private readonly IAppDbContext _context;

        public CreateOrderCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                UserId = request.UserId,
                TotalAmount = request.TotalAmount,
                OrderItems = request.OrderItems
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            return order.Id;
        }
    }
}