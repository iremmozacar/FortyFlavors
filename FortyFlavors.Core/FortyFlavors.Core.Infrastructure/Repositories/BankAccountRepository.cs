using System;
using FortyFlavors.Core.Application.Intefaces.Repository;
using FortyFlavors.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FortyFlavors.Core.Infrastructure.Repositories;

public class BankAccountRepository : GenericRepository<BusinessBankAccount>, IBankAccountRepository
{
    private readonly AppDbContext _context;

    public BankAccountRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<BusinessBankAccount> GetAccountByUserIdAsync(int userId)
    {
        return await _context.BusinessBankAccounts.FirstOrDefaultAsync(ba => ba.UserId == userId);
    }

    public async Task<IEnumerable<BusinessBankAccount>> GetAllBusinessAccountsAsync()
    {
        return await _context.BusinessBankAccounts.Where(ba => ba.IsBusinessAccount).ToListAsync();
    }
}