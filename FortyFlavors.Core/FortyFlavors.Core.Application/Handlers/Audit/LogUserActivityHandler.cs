using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Handlers.Audit
{
    public class LogUserActivityHandler : IRequestHandler<LogUserActivityRequest, bool>
    {
        private readonly ILogger<LogUserActivityHandler> _logger;

        public LogUserActivityHandler(ILogger<LogUserActivityHandler> logger)
        {
            _logger = logger;
        }

        public Task<bool> Handle(LogUserActivityRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("User Activity Logged: UserId={UserId}, Activity={Activity}, Timestamp={Timestamp}",
                request.UserId, request.Activity, request.Timestamp);

            return Task.FromResult(true);
        }
    }

    public class LogUserActivityRequest : IRequest<bool>
    {
        public int UserId { get; set; }
        public string Activity { get; set; }
        public DateTime Timestamp { get; set; }

        public LogUserActivityRequest(int userId, string activity, DateTime timestamp)
        {
            UserId = userId;
            Activity = activity;
            Timestamp = timestamp;
        }
    }
}