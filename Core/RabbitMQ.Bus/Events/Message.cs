using MediatR;

namespace RabbitMQ.Bus.Events
{
    public abstract class Message<T> : IRequest<T>
    {
        protected Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }

    public abstract class Message : Message<bool>
    {
        protected Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }
}