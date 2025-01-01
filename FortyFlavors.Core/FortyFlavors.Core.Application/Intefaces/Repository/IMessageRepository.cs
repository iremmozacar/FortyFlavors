using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IMessageRepository : IGenericRepository<Message>
{
    Task<IEnumerable<Message>> GetMessagesBySenderIdAsync(int senderId);
    Task<IEnumerable<Message>> GetMessagesByReceiverIdAsync(int receiverId);
}
