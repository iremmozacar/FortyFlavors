using System;
using FortyFlavors.Core.Application.Intefaces.Service;

namespace FortyFlavors.Core.Infrastructure.Services;

public class AuthorizationService : IAuthorizationService
{
    public async Task<bool> AuthorizeUserAsync(int userId, string requiredRole)
    {
       
        return await Task.FromResult(true);
    }

    public async Task<IEnumerable<string>> GetUserRolesAsync(int userId)
    {
       
        var roles = new List<string> { "User", "Admin" };
        return await Task.FromResult(roles); 
    }
}
