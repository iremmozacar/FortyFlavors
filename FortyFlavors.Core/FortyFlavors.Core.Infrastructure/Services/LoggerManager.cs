using FortyFlavors.Core.Application.Intefaces.Infrastructure;
using FortyFlavors.Core.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace FortyFlavors.Core.Infrastructure.Services
{
    public class LoggerManager : ILoggerManager
    {
        private readonly ILogger<LoggerManager> _logger;

        public LoggerManager(ILogger<LoggerManager> logger)
        {
            _logger = logger;
        }

        public void LogInfo(string message)
        {
            _logger.LogInformation(message);
        }

        public void LogWarn(string message)
        {
            _logger.LogWarning(message);
        }

        public void LogError(string message)
        {
            _logger.LogError(message);
        }

        public void LogDebug(string message)
        {
            _logger.LogDebug(message);
        }
    }
}