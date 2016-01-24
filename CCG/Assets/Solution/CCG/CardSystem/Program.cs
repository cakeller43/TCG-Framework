using System;
using CardSystem.Card;

namespace CardSystem
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Remove. Only for testing.
            string[] routingKeys = { "key1", "key2", "key3" };
            var consumer = new EventConsumer(routingKeys);

            Console.ReadLine();
        }
    }
}
