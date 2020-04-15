using System.Collections.Generic;
using RabbitMQ.Bus.Commands;
using Transfer.Domain.Models;

namespace Transfer.Domain.Commands
{
    public class TransferCommand : Command<IEnumerable<TransferLog>>
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}