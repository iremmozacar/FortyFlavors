using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Events.Orders
{
    public class OrderCancelledEvent : INotification
    {
        public int OrderId { get; set; }
        public string Reason { get; set; }

        public OrderCancelledEvent(int orderId, string reason)
        {
            OrderId = orderId;
            Reason = reason;
        }
    }

    public class OrderCancelledEventHandler : INotificationHandler<OrderCancelledEvent>
    {
        private readonly ILogger<OrderCancelledEventHandler> _logger;

        public OrderCancelledEventHandler(ILogger<OrderCancelledEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(OrderCancelledEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Order {OrderId} was cancelled. Reason: {Reason}.", notification.OrderId, notification.Reason);
 
            return Task.CompletedTask;
        }
    }
}