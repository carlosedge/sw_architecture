using Queueing.Interfaces;
using QueueingRabbitMQ.Handlers;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace QueueingRabbitMQ
{
    public class RabbitConsumer : IConsumer
    {
        private readonly IRabbitBasicConsumerHandler _consumerHandler;

        public void Consume(string channelName)
        {
            Console.WriteLine(" Press [enter] to exit.");

            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: channelName,
                                         durable: false,
                                         exclusive: false,
                                         autoDelete: false,
                                         arguments: null);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        _consumerHandler.Handle(channelName, model, ea);                        
                    };
                    channel.BasicConsume(queue: channelName,
                                         autoAck: true,
                                         consumer: consumer);
                    
                    Console.ReadLine();
                }                
            }
        }
    }
}
