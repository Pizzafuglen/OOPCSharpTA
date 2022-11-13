namespace CircleArea;

public class PlayingField
{
    public static void Main(string[] args)
    {
        Console.WriteLine("For the circle with the area 1, area and circumference:");
        Console.WriteLine(CircleArea.CalculateArea(1));
        Console.WriteLine(CircleCircumference.CalculateCircum(1));
        
        Console.WriteLine("\nFor the circle with the area 3, area and circumference:");
        Console.WriteLine(CircleArea.CalculateArea(3));
        Console.WriteLine(CircleCircumference.CalculateCircum(3));
        
        Console.WriteLine("\nFor the circle with the area 5, area and circumference:");
        Console.WriteLine(CircleArea.CalculateArea(5));
        Console.WriteLine(CircleCircumference.CalculateCircum(5));
    }
}