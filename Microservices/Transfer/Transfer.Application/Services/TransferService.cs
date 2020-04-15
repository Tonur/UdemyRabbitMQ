using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Bus.Bus.Interfaces;
using Transfer.Application.Interfaces;
using Transfer.Domain.Commands;
using Transfer.Domain.Interfaces;
using Transfer.Domain.Models;

namespace Transfer.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly IEventBus _eventBus;
        private readonly ITransferRepository _transferRepository;

        public TransferService(IEventBus eventBus, ITransferRepository transferRepository)
        {
            _eventBus = eventBus;
            _transferRepository = transferRepository;
        }

        public async Task<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return await _transferRepository.GetTransferLogs();
        }
    }
}
