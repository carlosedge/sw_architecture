using Queueing.Interfaces;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace QueueingRabbitMQ
{
    public class RabbitConsumer : IConsumer
    {
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
                        var body = ea.Body.ToArray();
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine($" [{channelName}] {message}" );
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
