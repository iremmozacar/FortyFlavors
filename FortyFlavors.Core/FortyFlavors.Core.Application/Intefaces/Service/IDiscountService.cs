using System;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IDiscountService
{
    Task ApplyDiscountAsync(int productId, decimal discountRate);
    Task<decimal> GetDiscountedPriceAsync(int productId);
}