using System;

namespace FortyFlavors.Core.Application.DTOs.CreateDto;

public class OrderItemCreateDto
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
