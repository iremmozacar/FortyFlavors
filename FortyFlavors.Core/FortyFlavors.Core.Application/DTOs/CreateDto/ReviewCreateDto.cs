using System;

namespace FortyFlavors.Core.Application.DTOs.CreateDto;

public class ReviewCreateDto
{
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
}