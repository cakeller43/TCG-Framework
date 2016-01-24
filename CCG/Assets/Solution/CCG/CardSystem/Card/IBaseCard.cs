namespace CardSystem.Card
{
    public interface IBaseCard
    {
        string CardName { get; set; }

        EventConsumer eventConsumer { get; set; }

    }
}
