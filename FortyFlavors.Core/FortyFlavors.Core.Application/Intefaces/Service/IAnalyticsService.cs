using System;
using FortyFlavors.Core.Application.DTOs.DtoS;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface IAnalyticsService
{
    Task<ReportDto> GetTopSellingProductsAsync(int limit);
    Task<ReportDto> GetSalesByCategoryAsync(DateTime startDate, DateTime endDate);
}