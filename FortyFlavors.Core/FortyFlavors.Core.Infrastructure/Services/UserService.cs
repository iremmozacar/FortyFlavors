using System;
using AutoMapper;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Application.Intefaces.Service;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Services;
public class UserService : Service<User>, IUserService
{
    private readonly IGenericRepository<User> _repository;
    private readonly IMapper _mapper;

    public UserService(IGenericRepository<User> repository, IMapper mapper) : base(repository)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public Task<UserDto> AddAsync(UserDto entity)
    {
        return Task.FromResult<UserDto>(null);
    }

    public Task<UserDto> CreateAsync(UserDto entity)
    {
        return Task.FromResult<UserDto>(null);
    }

    public async Task RegisterUserAsync(UserRegisterDto userRegisterDto)
    {
        var user = _mapper.Map<User>(userRegisterDto); 
        user.SetPassword(PasswordHasher.HashPassword(userRegisterDto.Password)); // Şifreyi hashleme
        await _repository.AddAsync(user);
    }

    public Task<UserDto> UpdateAsync(UserDto entity)
    {
        return Task.FromResult<UserDto>(null);
    }

    Task<IEnumerable<UserDto>> IService<UserDto>.GetAllAsync()
    {
        throw new NotImplementedException();
    }

    Task<UserDto> IService<UserDto>.GetByIdAsync(int id)
    {
        return Task.FromResult<UserDto>(null);
    }
}