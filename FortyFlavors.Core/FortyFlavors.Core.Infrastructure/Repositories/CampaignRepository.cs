using FortyFlavors.Core.Application.Intefaces.Repository;

using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure.Repositories
{
    public class CampaignRepository : GenericRepository<Campaign>, ICampaignRepository
    {
        private readonly AppDbContext _context;

        public CampaignRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Campaign>> GetActiveCampaignsAsync()
        {
            return await _context.Campaigns.Where(c => c.StartDate <= DateTime.UtcNow && c.EndDate >= DateTime.UtcNow).ToListAsync();
        }
    }
}