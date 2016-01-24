using System;
using CCG.Core;
using CCG.EventTypes;

namespace CCG
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Remove. Only for testing.
            var handler = new EventProducer();
            
            handler.PublishEvent(new TestEvent { RoutingKey = "key1"});
            handler.PublishEvent(new TestEvent { RoutingKey = "key2" });
            handler.PublishEvent(new TestEvent { RoutingKey = "key3" });
            handler.PublishEvent(new TestEvent { RoutingKey = "key4" });

            Console.ReadLine();
        }
    }
}
