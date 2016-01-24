using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace CardSystem
{
    public class EventConsumer
    {
        private string _queueName;
        private readonly RabbitMQ.Client.IModel _channel;

        public EventConsumer(IEnumerable<string> routingKeys)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (_channel = connection.CreateModel())
            {

                _queueName = _channel.QueueDeclare().QueueName;

                //Bind to exchange for each key.
                foreach (var key in routingKeys)
                {
                    _channel.QueueBind(queue: _queueName,
                                  exchange: "EventExchange",
                                  routingKey: key);
                }

                //What to do when a message is received.
                var consumer = new EventingBasicConsumer(_channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    var eventMessage = JObject.Parse(message);//event message in JSON form.
                    var routingKey = ea.RoutingKey;

                    //What to do when received.
                    Console.WriteLine(" [x] Received '{0}':'{1}'",
                                      routingKey, eventMessage);
                };

                _channel.BasicConsume(queue: _queueName,
                                      noAck: true,
                                      consumer: consumer);

                Console.Read();
            }
        }

    }
}
