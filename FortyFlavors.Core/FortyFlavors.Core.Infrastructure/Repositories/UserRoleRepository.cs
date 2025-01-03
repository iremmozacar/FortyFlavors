using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
{
    private readonly AppDbContext _context;

    public UserRoleRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserRole>> GetRolesByUserIdAsync(int userId)
    {
        return await _context.UserRoles.Where(ur => ur.UserId == userId).ToListAsync();
    }
}