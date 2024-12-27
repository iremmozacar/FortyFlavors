using System;

namespace FortyFlavors.Core.Application.DTOs.DtoS;

public class SummaryDto
{
    public int TotalOrders { get; set; }
    public int TotalUsers { get; set; }
    public decimal TotalRevenue { get; set; }
    public int ActiveCampaigns { get; set; }
}
