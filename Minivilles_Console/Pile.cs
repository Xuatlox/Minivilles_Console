namespace Minivilles_Console;

public class Pile
{
    public int Amount;
    public List<Card> Cards;

    public Pile(Card cardType, int amount)
    {
        Amount = amount;
        Cards = new List<Card>();
        for (int i = 0; i < amount; i++)
        {
            Cards.Add(cardType);
        }
    }
}