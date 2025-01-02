using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Events.Users
{
    public class UserRegisteredEvent : INotification
    {
        public int UserId { get; set; }
        public string Email { get; set; }

        public UserRegisteredEvent(int userId, string email)
        {
            UserId = userId;
            Email = email;
        }
    }

    public class UserRegisteredEventHandler : INotificationHandler<UserRegisteredEvent>
    {
        private readonly ILogger<UserRegisteredEventHandler> _logger;

        public UserRegisteredEventHandler(ILogger<UserRegisteredEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(UserRegisteredEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("User {UserId} registered with email {Email}.", notification.UserId, notification.Email);

            return Task.CompletedTask;
        }
    }
}