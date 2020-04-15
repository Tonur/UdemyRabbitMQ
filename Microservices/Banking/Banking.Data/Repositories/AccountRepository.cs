using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Data.Contexts;
using Banking.Domain.Interfaces;
using Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Banking.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _context;
        public AccountRepository(BankingDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _context.Accounts.ToListAsync();
        }

        public async Task<IEnumerable<Account>> Transfer(int requestFrom, int requestTo, decimal requestAmount)
        {
            var from = await _context.Accounts.FirstOrDefaultAsync(a => a.Id == requestFrom);
            var to = await _context.Accounts.FirstOrDefaultAsync(a => a.Id == requestTo);

            from.AccountBalance -= requestAmount;
            to.AccountBalance += requestAmount;

            await _context.SaveChangesAsync();

            return new[] {from, to};
        }
    }
}
