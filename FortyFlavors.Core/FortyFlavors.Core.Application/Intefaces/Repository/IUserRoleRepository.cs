using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IUserRoleRepository : IGenericRepository<UserRole>
{
    Task<IEnumerable<UserRole>> GetRolesByUserIdAsync(int userId);
}