using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IMessageRepository : IGenericRepository<Message>
{
    Task<IEnumerable<Message>> GetMessagesBySenderIdAsync(Guid senderId);
    Task<IEnumerable<Message>> GetMessagesByReceiverIdAsync(Guid receiverId);
}
