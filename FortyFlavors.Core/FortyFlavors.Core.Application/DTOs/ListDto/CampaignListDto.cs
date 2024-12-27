using System;

namespace FortyFlavors.Core.Application.DTOs.ListDto;

public class CampaignListDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal DiscountPercentage { get; set; }
    public bool IsActive { get; set; }
}
