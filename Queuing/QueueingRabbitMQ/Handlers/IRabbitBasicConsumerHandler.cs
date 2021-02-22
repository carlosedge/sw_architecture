using RabbitMQ.Client.Events;

namespace QueueingRabbitMQ.Handlers
{
    /// <summary>
    /// Handles RabbitMQ Basic Consumer messages.
    /// </summary>
    public interface IRabbitBasicConsumerHandler
    {
        /// <summary>
        /// Handles message.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="basicDeliverEventArgs"></param>
        void Handle(string queue, object model, BasicDeliverEventArgs basicDeliverEventArgs);
    }
}
