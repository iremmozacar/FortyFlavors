using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Infrastructure.Repositories
{
    public class TransactionsRepository : GenericRepository<Transaction>, ITransactionsRepository
    {
        private readonly AppDbContext _context;

        public TransactionsRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsByUserIdAsync(int userId)
        {
            return await _context.Transactions
                .Where(t => t.UserId == userId)
                .ToListAsync();
        }

        public async Task<decimal> GetTotalTransactionAmountAsync(int userId)
        {
            return await _context.Transactions
                .Where(t => t.UserId == userId)
                .SumAsync(t => t.Amount);
        }
    }
}