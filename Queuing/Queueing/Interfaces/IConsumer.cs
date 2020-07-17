using System;
using System.Collections.Generic;
using System.Text;

namespace Queueing.Interfaces
{
    public interface IConsumer
    {
        void Consume(string channel);
    }
}
