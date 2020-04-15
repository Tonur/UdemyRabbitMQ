using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Banking.Domain.Commands;
using Banking.Domain.Events;
using Banking.Domain.Interfaces;
using Banking.Domain.Models;
using MediatR;
using RabbitMQ.Bus.Bus.Interfaces;

namespace Banking.Domain.CommandHandlers
{
    public class CreateTransferCommandHandler : IRequestHandler<CreateTransferCommand, IEnumerable<Account>>
    {
        private readonly IEventBus _eventBus;
        private readonly IAccountRepository _accountRepository;
        public CreateTransferCommandHandler(IEventBus eventBus, IAccountRepository accountRepository)
        {
            _eventBus = eventBus;
            _accountRepository = accountRepository;
        }


        public async Task<IEnumerable<Account>> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            await _accountRepository.Transfer(request.From, request.To, request.Amount);

            _eventBus.PublishEvent(new TransferCompletedEvent());
            return await _accountRepository.GetAccounts();
        }
    }

    
}
