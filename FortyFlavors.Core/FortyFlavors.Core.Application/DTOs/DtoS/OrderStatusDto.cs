using System;

namespace FortyFlavors.Core.Application.DTOs.DtoS;

public class OrderStatusDto
{
    public int OrderId { get; set; }
    public string Status { get; set; }
    public DateTime UpdatedAt { get; set; }
}
