using System;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IAuthorizationService
{
    Task<bool> AuthorizeUserAsync(int userId, string requiredRole);
    Task<IEnumerable<string>> GetUserRolesAsync(int userId);
}