using System;
using FortyFlavors.Core.Application.DTOs.CreateDto;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.DTOs.UpdateDto;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDto>> GetAllAsync();
    Task<CategoryDto> GetByIdAsync(int id);
    Task<CategoryDto> CreateAsync(CategoryCreateDto categoryCreateDto);
    Task<CategoryDto> UpdateAsync(int id, CategoryUpdateDto categoryUpdateDto);
    Task<bool> DeleteAsync(int id);
}