using System;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Service;
using MediatR;

namespace FortyFlavors.Core.Infrastructure.Services;

public class NotificationService : INotificationService
{
    public async Task SendNotificationAsync(NotificationDto notification)
    {
      
        await Task.CompletedTask; 
    }

    public async Task<IEnumerable<NotificationDto>> GetUserNotificationsAsync(int userId)
    {
       
        var notifications = new List<NotificationDto>
        {
            new NotificationDto { Id = 1, UserId = userId, Message = "Welcome to FortyFlavors!", IsRead = false },
            new NotificationDto { Id = 2, UserId = userId, Message = "Your order has been shipped!", IsRead = true }
        };
        return await Task.FromResult(notifications); 
    }

    public async Task MarkAsReadAsync(int notificationId)
    {
        
        await Task.CompletedTask; 
    }
}
