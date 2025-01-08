using System;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IAuthenticationService
{
    Task<string> GenerateJwtTokenAsync(string username, IList<string> roles);
}
