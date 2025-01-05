using System.Threading;
using System.Threading.Tasks;
using FortyFlavors.Core.Application.Intefaces.Common;
using MediatR;

namespace FortyFlavors.Core.Application.Commands.Basket
{
    public class RemoveBasketCommand : IRequest
    {
        public int BasketId { get; set; }

        public RemoveBasketCommand(int basketId)
        {
            BasketId = basketId;
        }
    }

    public class RemoveBasketCommandHandler : IRequestHandler<RemoveBasketCommand>
    {
        private readonly IAppDbContext _context;

        public RemoveBasketCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = await _context.Baskets.FindAsync(request.BasketId);

            if (basket == null)
                throw new KeyNotFoundException("Sepet bulunamadı.");

            _context.Baskets.Remove(basket);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}