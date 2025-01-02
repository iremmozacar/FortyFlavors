using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Events.Orders
{
    public class OrderCompletedEvent : INotification
    {
        public int OrderId { get; set; }
        public DateTime CompletedAt { get; set; }

        public OrderCompletedEvent(int orderId, DateTime completedAt)
        {
            OrderId = orderId;
            CompletedAt = completedAt;
        }
    }

    public class OrderCompletedEventHandler : INotificationHandler<OrderCompletedEvent>
    {
        private readonly ILogger<OrderCompletedEventHandler> _logger;

        public OrderCompletedEventHandler(ILogger<OrderCompletedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(OrderCompletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Order {OrderId} completed at {CompletedAt}.", notification.OrderId, notification.CompletedAt);
      
            return Task.CompletedTask;
        }
    }
}