namespace Temperature;

public class PlayingField
{
    public static void Main(string[] args)
    {
        var celciusToFarh = CelciusFahrenheit.ConvertCelciusToFarh(1);
        
        Console.WriteLine(celciusToFarh);
        
        Console.WriteLine(CelciusFahrenheit.ConvertFahrenheitToCel(68));
    }
}