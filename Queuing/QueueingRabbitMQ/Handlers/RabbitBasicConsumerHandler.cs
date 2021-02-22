using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace QueueingRabbitMQ.Handlers
{
    public class RabbitBasicConsumerHandler : IRabbitBasicConsumerHandler
    {
        public void Handle(string queue, object model, BasicDeliverEventArgs basicDeliverEventArgs)
        {
            var body = basicDeliverEventArgs.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine($" [{queue}] {message}");
        }
    }
}
