using System;
using FortyFlavors.Core.Application.DTOs.DtoS;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IUserService : IService<UserDto>
{
    Task RegisterUserAsync(UserRegisterDto userRegisterDto);
}