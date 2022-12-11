using System;
using static System.Console;
public class IterationStatements
{
    public static void Main(string[] args)
    {
        int x = 0;
        while (x < 10)
        {
            ++x;
            WriteLine(x);
        }

        string password = string.Empty;
        int tries = 3;
        do
        {
            Write($"Enter your password, you have {tries} attempts left: ");
            password = ReadLine();
            tries--;
            if (tries <= 0)
            {
                WriteLine("You are just another dummy man, and not a hacker. Go read some book about hacking.");
                return;
            }
        }
        while (password != "1234");
        WriteLine("Belive or not, but you are true hackerman.");

        for (int y = 0; y <= 10; y++)
        {
            WriteLine(y);
        }

        string[] names = { "Adam", "Barry", "Charlie" };

        foreach (var name in names)
        {
            WriteLine($"{name} has {name.Length} characters.");
        }

    }
}