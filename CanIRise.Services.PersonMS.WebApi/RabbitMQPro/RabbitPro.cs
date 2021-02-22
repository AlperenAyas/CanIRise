using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.WebApi.RabbitMQPro
{
    public class RabbitPro : IRabbitPro
    {
        public RabbitPro()
        {
            RabbitInit();
        }
        public void RabbitInit()
        {
            var factory = new ConnectionFactory { Uri = new Uri("amqp://guest:guest@localhost:5672") };

            using var _connection = factory.CreateConnection();
            using var _channel = _connection.CreateModel();
            _channel.QueueDeclare("test-queue", durable: true, exclusive: false, autoDelete: false, arguments: null);

            var message = new { Name = "Producer", Message = "Report Stuffs" };
            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

            _channel.BasicPublish("", "test-queue", null, body);
        }
    }
}