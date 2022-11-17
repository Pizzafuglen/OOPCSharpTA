namespace Epoch;

public class PlayingField
{
    public static void Main(string[] args)
    {
        EpochCal ep = new EpochCal(31556926 * 2.5);
        
        Console.WriteLine(ep.calcWholeDays());
    }
}