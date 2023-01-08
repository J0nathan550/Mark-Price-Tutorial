using System;
using static System.Console;

public class FizzBuzz
{

    public static void Main(string[] args)
    {
        string fizzBuzz = "";
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                fizzBuzz += "Fizz, ";
            }
            else if (i % 5 == 0)
            {
                fizzBuzz += "Buzz, ";
            }
            else if (i % 5 == 0 && i % 3 == 0)
            {
                fizzBuzz += "FizzBuzz, ";
            }
            else
            {
                fizzBuzz += $"{i}, ";
            }
        }
        fizzBuzz = fizzBuzz.Substring(0, fizzBuzz.Length - 2);
        fizzBuzz += ".";
        Console.WriteLine(fizzBuzz);
    }

}