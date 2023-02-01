using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;


namespace AccountManagement.Framework.RabitMQ
{
    public class RabitMQProducer : IQueueProducer
    {
        public void SendMessage<T>(string queueName, T message)
        {
            var factory = new ConnectionFactory
            {
                //ToDo: اینو وقتی بردم تو یه سلوشن جدا حتما این بخش رو باید از appsetting بخونم
                HostName = "192.168.0.124",
                UserName = "account_user",
                Password = "account@123qwe",
                VirtualHost = "/account"
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare($"account-{queueName}", exclusive: false, autoDelete: false, durable: true);
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
            channel.BasicPublish(exchange: "", routingKey: $"account-{queueName}", body: body);
        }
        public void SendMessages<T>(string queueName, List<T> messages)
        {
            var factory = new ConnectionFactory
            {
                //ToDo: اینو وقتی بردم تو یه سلوشن جدا حتما این بخش رو باید از appsetting بخونم
                HostName = "192.168.0.124",
                Port= 5672,
                UserName = "account_user",
                Password = "account@123qwe",
                VirtualHost= "/account"
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();
            channel.QueueDeclare($"account-{queueName}", exclusive: false,autoDelete:false,durable:true);
            foreach (var message in messages)
            {
                var json = JsonConvert.SerializeObject(message);
                var body = Encoding.UTF8.GetBytes(json);
                channel.BasicPublish(exchange: "", routingKey: $"account-{queueName}", body: body);
            }
        }

    }
}
