using Minivilles_Console.Cards.Buildings;

namespace Minivilles_Console;

public class Player
{
    public int Money = 3;
    public List<Card> Cards = [new WheatField(), new Bakery()];
}