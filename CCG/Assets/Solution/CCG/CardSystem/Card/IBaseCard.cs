using System.Collections.Generic;
using CCG.EventTypes;

namespace CardSystem.Card
{
    public interface IBaseCard
    {
        string cardName { get; set; }

        List<GameEvent> relaventEvents { get; set; }

        EventConsumer eventConsumer { get; set; }

    }
}
