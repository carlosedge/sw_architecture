using Queueing;
using Queueing.Models;
using RabbitMQ.Client;
using System;
using System.Text;

namespace QueueingRabbitMQ
{
    public class RabbitProducer : IProducer
    {
        public bool Produce(Message message)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: message.Channel,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                
                var body = Encoding.UTF8.GetBytes(message.Text);

                channel.BasicPublish(exchange: "",
                                     routingKey: message.Channel,
                                     basicProperties: null,
                                     body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
            return true;
        }
    }
}
