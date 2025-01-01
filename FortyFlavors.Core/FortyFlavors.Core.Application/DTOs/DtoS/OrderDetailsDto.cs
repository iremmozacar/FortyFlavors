using System;

namespace FortyFlavors.Core.Application.DTOs.DtoS;

public class OrderDetailsDto
{
    public int Id { get; set; }
    public List<OrderItemDto> Items { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }
}
