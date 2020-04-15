using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Bus.Bus.Interfaces;
using Transfer.Domain.Events;
using Transfer.Domain.Interfaces;

namespace Transfer.Domain.EventHandlers
{
    public class TransferCompletedEventHandler : IEventHandler<TransferCompletedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferCompletedEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task Handle(TransferCompletedEvent @event)
        {
            await _transferRepository.Create(@event.From, @event.To, @event.Amount);
        }
    }
}
