using System;
using FortyFlavors.Core.Domain.Entities;

namespace FortyFlavors.Core.Application.Intefaces.Repository;

public interface IBankAccountRepository : IGenericRepository<BusinessBankAccount>
{
    Task<BusinessBankAccount> GetAccountByUserIdAsync(int userId);
    Task<IEnumerable<BusinessBankAccount>> GetAllBusinessAccountsAsync();
}