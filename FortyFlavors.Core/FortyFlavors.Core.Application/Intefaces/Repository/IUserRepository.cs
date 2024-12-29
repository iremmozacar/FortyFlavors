using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IUserRepository
{
    void AddUser(User user);
    User GetUserById(int userId);
    User GetUserByEmail(string email);
    IEnumerable<User> GetAllUsers();
    void UpdateUser(User user);
    void DeleteUser(int userId);
}
