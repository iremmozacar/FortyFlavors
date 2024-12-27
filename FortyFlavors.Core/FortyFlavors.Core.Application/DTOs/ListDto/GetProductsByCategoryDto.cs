using System;

namespace FortyFlavors.Core.Application.DTOs;

public class GetProductsByCategoryDto
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<ProductDto> Products { get; set; }
}
