using System.Threading;
using System.Threading.Tasks;
using FortyFlavors.Core.Application.Interfaces;
using FortyFlavors.Core.Domain.Entities;
using MediatR;
using BasketEntity = FortyFlavors.Core.Domain.Entities.Basket;

namespace FortyFlavors.Core.Application.Commands.Basket
{
    public class AddBasketCommand : IRequest<int>
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public AddBasketCommand(int userId, int productId, int quantity)
        {
            UserId = userId;
            ProductId = productId;
            Quantity = quantity;
        }
    }

    public class AddBasketCommandHandler : IRequestHandler<AddBasketCommand, int>
    {
        private readonly IAppDbContext _context;

        public AddBasketCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(AddBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = new Basket
            {
                UserId = request.UserId,
                BasketItems = new List<BasketItem>
                {
                    new BasketItem
                    {
                        ProductId = request.ProductId,
                        Quantity = request.Quantity
                    }
                }
            };

            _context.Baskets.Add(basket);
            await _context.SaveChangesAsync(cancellationToken);

            return basket.Id;
        }
    }
}