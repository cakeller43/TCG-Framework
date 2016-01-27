
using CardSystem.Card;

namespace CardSystem.CardLibrary
{
    public class CardFactory
    {
        public IBaseCard MakeCard(string cardType)
        {
            return new ConcreteBaseCard();
        }
    }
}
