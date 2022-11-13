namespace Temperature;

public class CelciusFahrenheit
{
    public static double ConvertCelcius(double temp)
    {
        return 32 + temp * 9 / 5;
    }

    public static double ConvertFahrenheit(double temp)
    {
        return (temp - 32) * 5 / 9;
    }
}