using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain.Models;
using RabbitMQ.Bus.Commands;

namespace Banking.Domain.Commands
{
    public class TransferCommand : Command<IEnumerable<Account>>
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
