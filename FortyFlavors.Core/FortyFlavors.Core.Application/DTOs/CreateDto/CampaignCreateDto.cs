using System;

namespace FortyFlavors.Core.Application.DTOs.CreateDto;

public class CampaignCreateDto
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal DiscountPercentage { get; set; }
}
