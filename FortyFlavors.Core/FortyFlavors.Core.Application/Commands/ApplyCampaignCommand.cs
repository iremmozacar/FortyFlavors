using System;
using MediatR;

namespace FortyFlavors.Core.Application.Commands;

public class ApplyCampaignCommand:IRequest<bool>
{
    public int ProductId { get; set; }
    public decimal DiscountPercentage { get; set; }

    public ApplyCampaignCommand(int productId, decimal discountPercentage)
    {
        ProductId = productId;
        DiscountPercentage = discountPercentage;
    }
}
