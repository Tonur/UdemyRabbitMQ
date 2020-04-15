using System;
using Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Banking.Data.Contexts
{
    public class BankingDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public BankingDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
