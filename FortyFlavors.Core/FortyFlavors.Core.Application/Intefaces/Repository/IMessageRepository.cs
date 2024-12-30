using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IMessageRepository
{
    void AddMessage(Message message);
    Message GetMessageById(int messageId);
    IEnumerable<Message> GetMessagesBySenderId(int senderId); 
    IEnumerable<Message> GetMessagesByReceiverId(int receiverId); 
    IEnumerable<Message> GetMessagesByOrderId(int orderId); 
    void UpdateMessage(Message message);
    void DeleteMessage(int messageId);
}
