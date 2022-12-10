using  System;
using System.Globalization;

public class Formatting
{
    public static void Main(string[] args)
    {
        // CultureInfo cultureInfo = new CultureInfo("en-US");
        // int applesCount = 12;
        // decimal pricePerApple = 0.35M;

        // decimal currentPrice = applesCount * pricePerApple;

        // Console.WriteLine($"{applesCount} apples costs {currentPrice.ToString("C", cultureInfo)}"); // depends on where computer is. 

        // string applesText = "Apples";
        // int amountOfApples = 1234;
        // string bananasText = "Bananas";
        // int amountOfBananas = 56789;

        // decimal cost = 12452.12M;

        // Console.WriteLine(format: "{0,-8} {1, 6:C}", arg0: applesText, arg1: amountOfApples.ToString("C", cultureInfo));
        // Console.WriteLine(format: "{0,-8} {1, 6:N0}", arg0: bananasText, arg1: amountOfBananas.ToString("C", cultureInfo));
        // Console.WriteLine($"Your amount of money: {cost.ToString("C", cultureInfo)}");

        // Console.ReadKey();

        // Console.Write("Type your first name and press ENTER: ");
        // string firstName = Console.ReadLine();
        // Console.Write("Type your age and press ENTER: ");
        // string age = Console.ReadLine();

        // Console.WriteLine($"Hello {firstName}, you look good for {age}.");

        Console.Write("Press any key combination: ");
        Console.WriteLine();
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine($"You pressed: {key.Key} {key.KeyChar} {key.Modifiers}.");

    }

}