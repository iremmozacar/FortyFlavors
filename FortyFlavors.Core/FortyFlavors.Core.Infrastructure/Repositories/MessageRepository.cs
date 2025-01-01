using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using FortyFlavors.Core.Infrastructure;
using FortyFlavors.Core.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MessageRepository : GenericRepository<Message>, IMessageRepository
{
    private readonly AppDbContext _context;

    public MessageRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Message>> GetMessagesBySenderIdAsync(int senderId)
    {
        return await _context.Messages.Where(m => m.SenderId == senderId).ToListAsync();
    }

    public async Task<IEnumerable<Message>> GetMessagesByReceiverIdAsync(int receiverId)
    {
        return await _context.Messages.Where(m => m.ReceiverId == receiverId).ToListAsync();
    }
}