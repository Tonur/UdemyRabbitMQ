using AdminPanel.Shared;
using AdminPanel.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Client.Services
{
    public interface IBankingService
    {
        Task<List<Account>> GetAccounts();
        Task<List<TransferDTO>> GetTransferHistory();
    }
}
