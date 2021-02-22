using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.ReportMS.WebApi.RabbitMQ
{
    public class Rabbit : IRabbit
    {
        public Rabbit()
        {
            RabbitInit();
        }


        public async Task RabbitInit(){
            var factory = new ConnectionFactory { Uri = new Uri("amqp://guest:guest@localhost:5672") };

            using var _connection = factory.CreateConnection();
            using var _channel = _connection.CreateModel();
            _channel.QueueDeclare("test-queue", durable: true, exclusive: false, autoDelete: false, arguments: null);

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(body);
            };
            _channel.BasicConsume("test-queue", false, consumer);

            //var message = new { Name = "Producer", Message = "Report Stuffs" };
            //var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

            //channel.BasicPublish("", "test-queue", null, body);
        }
    }
}
