namespace Temperature;

public class PlayingField
{
    public static void Main(string[] args)
    {
        var celciusToFarh = CelciusFahrenheit.ConvertCelcius(20);
        
        Console.WriteLine(celciusToFarh);
        
        Console.WriteLine(CelciusFahrenheit.ConvertFahrenheit(68));
    }
}