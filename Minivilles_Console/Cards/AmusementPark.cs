namespace Minivilles_Console.Cards;

public class AmusementPark : Card
{
    public AmusementPark()
    {
        this.Name = "Amusement Park";
        this.Type = "Monument";
        this.Cost = 16;
        this.Stackable = false;
        this.AnyRound = false;
    }
}