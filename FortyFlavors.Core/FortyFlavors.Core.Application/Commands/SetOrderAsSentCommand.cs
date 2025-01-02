using MediatR;

namespace FortyFlavors.Core.Application.Commands.Orders
{
    public class SetOrderAsSentCommand : IRequest
    {
        public int OrderId { get; set; }

        public SetOrderAsSentCommand(int orderId)
        {
            OrderId = orderId;
        }
    }
}