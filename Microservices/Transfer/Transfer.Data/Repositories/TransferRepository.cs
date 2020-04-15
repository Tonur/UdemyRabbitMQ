using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Transfer.Data.Contexts;
using Transfer.Domain.Interfaces;
using Transfer.Domain.Models;

namespace Transfer.Data.Repositories
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _context;

        public TransferRepository(TransferDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return await _context.TransferLogs.ToListAsync();
        }

        public async Task Create(int from, int to, decimal amount)
        {
            await _context.TransferLogs.AddAsync(new TransferLog{ FromAccount = from, ToAccount = to, Amount = amount});
            await _context.SaveChangesAsync();
        }
    }
}
