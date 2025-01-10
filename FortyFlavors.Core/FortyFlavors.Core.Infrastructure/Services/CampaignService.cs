using System;
using AutoMapper;
using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Application.Intefaces.Service;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Infrastructure.Services;

public class CampaignService : ICampaignService
{
    private readonly IGenericRepository<Campaign> _repository;
    private readonly IMapper _mapper;

    public CampaignService(IGenericRepository<Campaign> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task CreateCampaignAsync(CampaignDto campaign)
    {
        // Kampanya oluşturma işlemleri yapılabilir
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
        // Kampanyayı bitirme işlemi
        await Task.CompletedTask;
    }

    public async Task<IEnumerable<CampaignDto>> GetAllAsync()
    {
        var campaigns = await _repository.GetAllAsync();
        return _mapper.Map<IEnumerable<CampaignDto>>(campaigns);
    }
}