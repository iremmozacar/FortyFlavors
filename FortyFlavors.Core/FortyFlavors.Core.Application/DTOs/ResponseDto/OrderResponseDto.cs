using System;

namespace FortyFlavors.Core.Application.DTOs;

public class OrderResponseDto
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderItemDto> OrderItems { get; set; }
    public decimal TotalAmount { get; set; }
}
