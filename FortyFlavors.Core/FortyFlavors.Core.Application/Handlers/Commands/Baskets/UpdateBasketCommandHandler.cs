using System.Threading;
using System.Threading.Tasks;
using FortyFlavors.Core.Application.Intefaces.Common;
using MediatR;

namespace FortyFlavors.Core.Application.Commands.Basket
{
    public class UpdateBasketCommand : IRequest
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public UpdateBasketCommand(int basketId, int productId, int quantity)
        {
            BasketId = basketId;
            ProductId = productId;
            Quantity = quantity;
        }
    }

    public class UpdateBasketCommandHandler : IRequestHandler<UpdateBasketCommand>
    {
        private readonly IAppDbContext _context;

        public UpdateBasketCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateBasketCommand request, CancellationToken cancellationToken)
        {
            var basketItem = await _context.BasketItems
                .FindAsync(new { request.BasketId, request.ProductId });

            if (basketItem == null)
                throw new KeyNotFoundException("Sepet öğesi bulunamadı.");

            basketItem.Quantity = request.Quantity;
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}