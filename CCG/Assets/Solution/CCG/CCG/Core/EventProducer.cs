using System;
using System.Text;
using CCG.EventTypes;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace CCG.Core
{
    public class EventProducer
    {
        private ConnectionFactory factory;
        public EventProducer()
        {
            factory = new ConnectionFactory() {HostName = "localhost"};
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(exchange: "EventExchange", type: "direct");
            }
        }

        public void PublishEvent(IGameEvent eventToPublish)
        {
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {

                string message = JsonConvert.SerializeObject(eventToPublish);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "EventExchange",
                                      routingKey: eventToPublish.RoutingKey,
                                      basicProperties: null,
                                      body: body);
                Console.WriteLine("[x] Sent {0}", message);
            }

        }



    }
}
