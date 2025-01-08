using System;
using FortyFlavors.Core.Application.DTOs;
using FortyFlavors.Core.Application.DTOs.DtoS;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IOrderService
{
    Task<IEnumerable<OrderDto>> GetAllAsync();
    Task<OrderDto> GetByIdAsync(int id);
    Task<OrderDto> CreateAsync(OrderCreateDto orderCreateDto);
    Task<bool> CancelAsync(int id);
}