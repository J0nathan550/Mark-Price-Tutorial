using System;
using static System.Console;

public class HandlingExceptions
{

    public static void Main(string[] args)
    {
        try
        {
            Write("Enter a number between 0 and 255: ");
            string firstNumber = ReadLine();
            Write("Enter another number between 0 and 255: ");
            string secondNumber = ReadLine();
            int.TryParse(firstNumber, out int number);
            int.TryParse(secondNumber, out int numberSecond);
            WriteLine($"{number} divided by {numberSecond} is {number / numberSecond}");
        }
        catch(FormatException)
        {
            WriteLine("Input string was not in a correct format.");
        }
    }

}