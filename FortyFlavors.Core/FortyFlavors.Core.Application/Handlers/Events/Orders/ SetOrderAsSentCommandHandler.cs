using System.Threading;
using System.Threading.Tasks;
using FortyFlavors.Core.Application.Interfaces;
using MediatR;

namespace FortyFlavors.Core.Application.Commands.Orders
{
    public class SetOrderAsSentCommandHandler : IRequestHandler<SetOrderAsSentCommand>
    {
        private readonly IAppDbContext _context;

        public SetOrderAsSentCommandHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(SetOrderAsSentCommand request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FindAsync(request.OrderId);
            if (order == null)
            {
                throw new KeyNotFoundException("Sipariş bulunamadı.");
            }

            order.Status = "Gönderildi";
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}