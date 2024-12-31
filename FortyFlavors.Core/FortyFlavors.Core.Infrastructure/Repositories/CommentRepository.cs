using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using FortyFlavors.Core.Infrastructure;
using FortyFlavors.Core.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CommentRepository : GenericRepository<Comment>, ICommentRepository
{
    private readonly AppDbContext _context;

    public CommentRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Comment>> GetCommentsByProductIdAsync(Guid productId)
    {
        return await _context.Comments.Where(c => c.ProductId == productId).ToListAsync();
    }
}