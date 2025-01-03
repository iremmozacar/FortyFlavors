using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface ICampaignRepository : IGenericRepository<Campaign>
{
    Task<IEnumerable<Campaign>> GetCampaignsByBusinessIdAsync(int businessId);
}