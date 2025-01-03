using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IEnumerable<Campaign>> GetCampaignsByBusinessIdAsync(int businessId)
        {
            return await _context.Campaigns.Where(c => c.BusinessId == businessId).ToListAsync();
        }
    }
}