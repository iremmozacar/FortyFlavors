using FortyFlavors.Core.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FortyFlavors.Core.Application.Intefaces.Repository
{
    public interface ITransactionsRepository : IGenericRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetTransactionsByUserIdAsync(int userId);
        Task<decimal> GetTotalTransactionAmountAsync(int userId);
    }
}