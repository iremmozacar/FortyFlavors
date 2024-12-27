using System;

namespace FortyFlavors.Core.Application.DTOs;

public class GetProductsResponseDto
{
    public List<ProductDto> Products { get; set; }
    public int TotalCount { get; set; }
}
