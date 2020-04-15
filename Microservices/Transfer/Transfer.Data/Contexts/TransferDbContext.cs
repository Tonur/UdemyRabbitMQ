using Microsoft.EntityFrameworkCore;
using Transfer.Domain.Models;

namespace Transfer.Data.Contexts
{
    public class TransferDbContext : DbContext
    {
        public DbSet<TransferLog> TransferLogs { get; set; }

        public TransferDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
