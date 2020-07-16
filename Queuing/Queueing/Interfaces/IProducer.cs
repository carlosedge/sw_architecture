using Queueing.Models;
using System;

namespace Queueing
{
    public interface IProducer
    {
        public bool Produce(Message message);
    }
}
