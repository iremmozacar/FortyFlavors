using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IBusinessRepository : IGenericRepository<Business>
{
    Task<Business> GetBusinessWithCampaignsAsync(int businessId);
}