namespace Temperature;

public class CelciusFahrenheit
{
    public static double ConvertCelciusToFarh(double temp)
    {
        return 32 + temp * 9 / 5;
    }

    public static double ConvertFahrenheitToCel(double temp)
    {
        return (temp - 32) * 5 / 9;
    }
}