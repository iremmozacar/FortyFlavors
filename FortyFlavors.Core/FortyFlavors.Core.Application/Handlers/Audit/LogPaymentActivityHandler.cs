using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Handlers.Audit
{
    public class LogPaymentActivityHandler : IRequestHandler<LogPaymentActivityRequest, bool>
    {
        private readonly ILogger<LogPaymentActivityHandler> _logger;

        public LogPaymentActivityHandler(ILogger<LogPaymentActivityHandler> logger)
        {
            _logger = logger;
        }

        public Task<bool> Handle(LogPaymentActivityRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Payment Activity Logged: PaymentId={PaymentId}, Activity={Activity}, Timestamp={Timestamp}",
                request.PaymentId, request.Activity, request.Timestamp);

            return Task.FromResult(true);
        }
    }

    public class LogPaymentActivityRequest : IRequest<bool>
    {
        public int PaymentId { get; set; }
        public string Activity { get; set; }
        public DateTime Timestamp { get; set; }

        public LogPaymentActivityRequest(int paymentId, string activity, DateTime timestamp)
        {
            PaymentId = paymentId;
            Activity = activity;
            Timestamp = timestamp;
        }
    }
}