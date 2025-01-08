using System;
using FortyFlavors.Core.Application.DTOs.DtoS;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IMessageService
{
    Task SendMessageAsync(MessageDto message);
    Task<IEnumerable<MessageDto>> GetMessagesAsync(int userId);
    Task DeleteMessageAsync(int messageId);
}