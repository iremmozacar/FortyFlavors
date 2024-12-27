using System;

namespace FortyFlavors.Core.Application.DTOs.CreateDto;

public class AddBasketDto
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}
