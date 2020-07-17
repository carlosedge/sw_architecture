using Microsoft.Extensions.DependencyInjection;
using Queueing.Interfaces;
using QueueingRabbitMQ;
using System;

namespace QueueingExampleConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string channelName = GetChannelName(args);
            
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IConsumer, RabbitConsumer>()
                .BuildServiceProvider();

            IConsumer consumer = serviceProvider.GetService<IConsumer>();
            consumer.Consume(channelName);

        }

        private static string GetChannelName(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("You need to specify the channel");
                throw new NullReferenceException();
            }
            return args[0];
        }
    }
}

