using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Handlers.Audit
{
    public class LogOrderActivityHandler : IRequestHandler<LogOrderActivityRequest, bool>
    {
        private readonly ILogger<LogOrderActivityHandler> _logger;

        public LogOrderActivityHandler(ILogger<LogOrderActivityHandler> logger)
        {
            _logger = logger;
        }

        public Task<bool> Handle(LogOrderActivityRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Order Activity Logged: OrderId={OrderId}, Activity={Activity}, Timestamp={Timestamp}",
                request.OrderId, request.Activity, request.Timestamp);

            return Task.FromResult(true);
        }
    }

    public class LogOrderActivityRequest : IRequest<bool>
    {
        public int OrderId { get; set; }
        public string Activity { get; set; }
        public DateTime Timestamp { get; set; }

        public LogOrderActivityRequest(int orderId, string activity, DateTime timestamp)
        {
            OrderId = orderId;
            Activity = activity;
            Timestamp = timestamp;
        }
    }
}