using System.Dynamic;

namespace ConsoleApp1;

public class Screen
{
    private string screenId;
    private int screenNum;

    public Screen(string screenId, int screenNum)
    {
        this.screenId = screenId;
        this.screenNum = screenNum;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("You can either:\ncreate an object -o\nview an object -v\nor close the console -c");
        while (true)
        {
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "o":
                    Console.WriteLine("You decided to create an object\nYou can now enter the id of the screen\nor exit by typing close");
                    string screenId = Console.ReadLine();
                    Console.WriteLine("Now enter the number on the screen");
                    int screenNumber = Convert.ToInt32(Console.ReadLine());
                    var screen = new Screen(screenId, screenNumber);
                    Console.WriteLine("Cool you just created a screen with the id = " + screen.screenId + ", and the number " + screen.screenNum);
                    break;
            }
        }
    }
}