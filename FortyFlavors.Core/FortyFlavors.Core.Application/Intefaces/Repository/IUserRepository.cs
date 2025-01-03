using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User> GetUserByEmailAsync(string email);
    Task<IEnumerable<User>> SearchUsersAsync(string searchTerm);
}
