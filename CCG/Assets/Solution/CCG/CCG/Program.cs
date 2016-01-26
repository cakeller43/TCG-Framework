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
            
            handler.PublishEvent(new GameEvent { RoutingKey = "key1"});
            handler.PublishEvent(new GameEvent { RoutingKey = "key2" });
            handler.PublishEvent(new GameEvent { RoutingKey = "key3" });
            handler.PublishEvent(new GameEvent { RoutingKey = "key4" });

            Console.ReadLine();
        }
    }
}
