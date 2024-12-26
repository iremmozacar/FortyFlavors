using System;

namespace FortyFlavors.Core.Application.DTOs;

public class OrderCreateDto
{
    public int UserId { get; set; }
    public List<OrderItemDto> OrderItems { get; set; }
    public decimal TotalAmount { get; set; }
}
