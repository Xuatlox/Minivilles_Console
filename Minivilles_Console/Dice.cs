namespace Minivilles_Console;

public class Dice
{
    public int Face;
    private Random _random = new Random();

    public int Throw()
    {
        Face = _random.Next(1,7);
        return Face;
    }
}