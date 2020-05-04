using AdminPanel.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Client.Services
{
    public interface ITransferService
    {
        public Task Transfer(TransferDTO transferDTO);
    }
}
