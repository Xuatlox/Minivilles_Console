using System.Security.Claims;

namespace Minivilles_Console.Cards;

public class TrainStation : Card
{
    public TrainStation()
    {
        this.Name = "Train Station";
        this.Type = "Monument";
        this.Cost = 4;
        this.Stackable = false;
        this.AnyRound = false;
    }
}