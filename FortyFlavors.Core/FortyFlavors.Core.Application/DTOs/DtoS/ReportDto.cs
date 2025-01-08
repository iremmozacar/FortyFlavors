using System;

namespace FortyFlavors.Core.Application.DTOs.DtoS;

public class ReportDto
{
    public string Title { get; set; } 
    public Dictionary<string, decimal> Data { get; set; } 
    public DateTime GeneratedAt { get; set; }
}
