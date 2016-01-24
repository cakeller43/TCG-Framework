using System.Collections.Generic;
using CardSystem.Card;
using Newtonsoft.Json.Linq;

namespace CardSystem.CardLibrary
{
    public static class CardParser
    {
        public static RawCardData BuildCardLibrary()
        {
            JObject JallCards = JObject.Parse(CardSystem.Properties.Resources.cardSource);

            var allCards = JallCards.ToObject<RawCardData>(); 
            return allCards;

        }
    }

    public class RawCardData
    {
        public List<BaseCard> AllCards { get; set; }
    }
}
