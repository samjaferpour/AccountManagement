using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Framework.RabitMQ
{
    public interface IQueueProducer
    {
       void SendMessage<T>(string queueName, T message);
        void SendMessages<T>(string queueName, List<T> messages);

    }
}
