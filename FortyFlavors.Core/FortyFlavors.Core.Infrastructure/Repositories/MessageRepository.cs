using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class MessageRepository : IMessageRepository
{
    public void AddMessage(Message message)
    {
        throw new NotImplementedException();
    }

    public void DeleteMessage(int messageId)
    {
        throw new NotImplementedException();
    }

    public Message GetMessageById(int messageId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Message> GetMessagesByOrderId(int orderId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Message> GetMessagesByReceiverId(int receiverId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Message> GetMessagesBySenderId(int senderId)
    {
        throw new NotImplementedException();
    }

    public void UpdateMessage(Message message)
    {
        throw new NotImplementedException();
    }
}
