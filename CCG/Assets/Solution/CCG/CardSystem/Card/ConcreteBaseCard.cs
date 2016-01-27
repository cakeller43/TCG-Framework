using System.Collections.Generic;
using CCG.EventTypes;

namespace CardSystem.Card
{
    public class ConcreteBaseCard : IBaseCard
    {
        public string cardName { get; set; }
        public List<GameEvent> relaventEvents { get; set; }
        public EventConsumer eventConsumer { get; set; }
    }
}
