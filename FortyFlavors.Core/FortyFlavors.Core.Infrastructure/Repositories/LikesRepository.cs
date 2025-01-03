using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class LikesRepository : GenericRepository<Likes>, ILikesRepository
{
    private readonly AppDbContext _context;

    public LikesRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<int> GetLikesCountByProductIdAsync(int productId)
    {
        return await _context.Likes.CountAsync(l => l.ProductId == productId);
    }

    public async Task<bool> HasUserLikedAsync(int userId, int productId)
    {
        return await _context.Likes.AnyAsync(l => l.UserId == userId && l.ProductId == productId);
    }
}