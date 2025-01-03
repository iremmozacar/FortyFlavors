using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure.Repositories
{
    public class BusinessRepository : GenericRepository<Business>, IBusinessRepository
    {
        private readonly AppDbContext _context;

        public BusinessRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Business> GetBusinessByOwnerIdAsync(int ownerId)
        {
            return await _context.Businesses.FirstOrDefaultAsync(b => b.OwnerId == ownerId);
        }

        public async Task<Business> GetBusinessWithCampaignsAsync(int businessId)
        {
            return await _context.Businesses
                .Include(b => b.Campaigns)
                .FirstOrDefaultAsync(b => b.Id == businessId);
        }
    }
}