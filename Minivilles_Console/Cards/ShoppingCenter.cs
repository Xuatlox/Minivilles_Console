namespace Minivilles_Console.Cards;

public class ShoppingCenter : Card
{
    public ShoppingCenter()
    {
        this.Name = "Shopping Center";
        this.Type = "Monument";
        this.Cost = 10;
        this.Stackable = false;
        this.AnyRound = false;
    }
}