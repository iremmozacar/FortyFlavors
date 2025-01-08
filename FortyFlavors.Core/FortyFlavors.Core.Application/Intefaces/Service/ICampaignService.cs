using System;
using FortyFlavors.Core.Application.DTOs.DtoS;

namespace FortyFlavors.Core.Application.Intefaces.Service;

public interface ICampaignService
{
    Task CreateCampaignAsync(CampaignDto campaign);
    Task<IEnumerable<CampaignDto>> GetActiveCampaignsAsync();
    Task EndCampaignAsync(int campaignId);
}