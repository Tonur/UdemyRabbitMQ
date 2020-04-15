using RabbitMQ.Bus.Events;

namespace Transfer.Domain.Events
{
    public class TransferCompletedEvent : Event
    {
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }

        public TransferCompletedEvent(int from, int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}