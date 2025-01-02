using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Events.Users
{
    public class UserDeletedEvent : INotification
    {
        public int UserId { get; set; }
        public string Email { get; set; }

        public UserDeletedEvent(int userId, string email)
        {
            UserId = userId;
            Email = email;
        }
    }

    public class UserDeletedEventHandler : INotificationHandler<UserDeletedEvent>
    {
        private readonly ILogger<UserDeletedEventHandler> _logger;

        public UserDeletedEventHandler(ILogger<UserDeletedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(UserDeletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("User {UserId} with email {Email} was deleted.", notification.UserId, notification.Email);
 
            return Task.CompletedTask;
        }
    }
}