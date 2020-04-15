using System.Collections.Generic;
using System.Threading.Tasks;
using Transfer.Domain.Models;

namespace Transfer.Domain.Interfaces
{
    public interface ITransferRepository
    {
        Task<IEnumerable<TransferLog>> GetTransferLogs();
        Task Create(int from, int to, decimal amount);
    }
}
