using System;
using RabbitMQ.Bus.Events;

namespace RabbitMQ.Bus.Commands
{
    public abstract class Command<T> : Message<T>
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; protected set; }
    }

    public abstract class Command : Command<bool>
    {
        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; protected set; }
    }
}