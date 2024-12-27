using System;

namespace FortyFlavors.Core.Application.DTOs.CreateDto;

public class OrderSummaryDto
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; }
    public int TotalItems { get; set; }
}
