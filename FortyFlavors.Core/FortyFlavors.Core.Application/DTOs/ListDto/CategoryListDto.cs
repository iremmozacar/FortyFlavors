using System;

namespace FortyFlavors.Core.Application.DTOs.ResponseDto;

public class CategoryListDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ProductCount { get; set; }
}
