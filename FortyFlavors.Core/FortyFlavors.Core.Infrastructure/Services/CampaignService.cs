using System;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Service;

namespace FortyFlavors.Core.Infrastructure.Services;

public class CampaignService : ICampaignService
{
   
 
        public async Task CreateCampaignAsync(CampaignDto campaign)
        {
            
            await Task.CompletedTask; 
        }

        public async Task<IEnumerable<CampaignDto>> GetActiveCampaignsAsync()
        {
            // Örnek kampanyalar
            var campaigns = new List<CampaignDto>
        {
            new CampaignDto { Id = 1, Name = "Winter Sale", DiscountPercentage = 10 },
            new CampaignDto { Id = 2, Name = "Summer Sale", DiscountPercentage = 20 }
        };
            return await Task.FromResult(campaigns); 
        }

        public async Task EndCampaignAsync(int campaignId)
        {
            
            await Task.CompletedTask; 
        }
    }

