using System;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Service;

namespace FortyFlavors.Core.Infrastructure.Services;

public class MessageService : IMessageService
{
    public async Task SendMessageAsync(MessageDto message)
    {
        
        await Task.CompletedTask; 
    }

    public async Task<IEnumerable<MessageDto>> GetMessagesAsync(int userId)
    {
        
        var messages = new List<MessageDto>
        {
            new MessageDto { Id = 1, SenderId = userId, ReceiverId = 2, Content = "Hello!" },
            new MessageDto { Id = 2, SenderId = 2, ReceiverId = userId, Content = "Hi there!" }
        };
        return await Task.FromResult(messages); 
    }

    public async Task DeleteMessageAsync(int messageId)
    {
       
        await Task.CompletedTask;
}
}
