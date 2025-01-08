using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Application.Intefaces.Service;

namespace FortyFlavors.Core.Infrastructure.Services;

public class Service<T> : IService<T> where T : class
{
    private readonly IGenericRepository<T> _repository;

    public Service(IGenericRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await _repository.AddAsync(entity);
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        await _repository.UpdateAsync(entity);
        return entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null)
            return false;

        await _repository.DeleteAsync(entity);
        return true;
    }

    public async Task<T> CreateAsync(T entity) 
    {
        await _repository.AddAsync(entity);
        return entity;
    }
}