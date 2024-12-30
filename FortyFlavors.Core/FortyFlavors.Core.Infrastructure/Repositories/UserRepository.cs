using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public void AddUser(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(int userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public User GetUserByEmail(string email)
    {
        throw new NotImplementedException();
    }

    public User GetUserById(int userId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> SearchUsers(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}
