using System;

namespace FortyFlavors.Core.Application.DTOs.DtoS;

public class OrderDto
{
    public int Id { get; set; }
    public string Status { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime CreatedAt { get; set; }
}
