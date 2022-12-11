using System;
using static System.Console;
using System.IO;
public class SelectionStatements
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            WriteLine("There are no arguments in project.");
        }
        else
        {
            WriteLine("There is at least one argument in project.");
        }

        object o = 12;
        int j = 3;
        if (o is int i)
        {
            WriteLine($"{i} x {j} = {i * j}");
        }
        else
        {
            WriteLine("O variable is not an int, so I can't multiply.");
        }

    A_label: //anchor point, can be named however you like
        int randomNumber = (new Random().Next(1, 7));
        WriteLine($"My random number is number: {randomNumber}");

        switch (randomNumber)
        {
            case 1:
                WriteLine($"One");
                break;
            case 2:
                WriteLine($"Two");
                goto case 1;
                break;
            case 3:

                break;
            case 4:
                WriteLine($"Three our four");
                goto case 1;
                break;
            case 5:
                System.Threading.Thread.Sleep(500);
                goto A_label;
                break;
            default:
                WriteLine("Default");
                break;
        }

        string path = @"C:\Users\J0nathan550\Visual Projects\Mark Price Tutorial\Chapter03\SelectionStatements";
        Write("Press R to read, Press W to write.");
        ConsoleKeyInfo key = ReadKey();
        WriteLine();

        Stream s = null;

        if (key.Key == ConsoleKey.R)
        {
            s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
        }
        else
        {
            s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
        }

        string message = string.Empty;

        switch (s)
        {
            case FileStream writeableFile when s.CanWrite:
                message = "The stream is a file that I can write to.";
                break;
            case FileStream readOnlyFile:
                message = "The stream is a read-only file.";
                break;
            case MemoryStream ms:
                message = "The stream is memory address.";
                break;
            default:
                message = "The stream is some other type.";
                break;
            case null:
                message = "The stream is null";
                break;
        }
        s.Close();
        WriteLine(message);
        WriteLine();

        Write("Press R to read, Press W to write.");
        key = ReadKey();
        WriteLine();

        s = null;

        if (key.Key == ConsoleKey.R)
        {
            s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Read);
        }
        else
        {
            s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate, FileAccess.Write);
        }

        message = string.Empty;

        message = s switch { 
            FileStream writeableFile when s.CanWrite => "The stream is a file that I can write to.",
            FileStream readOnlyFile => "The stream is a read-only file",
            MemoryStream ms => "The stream is a memory address",
            null => "The stream is null",
            _ => "The strea is some other type."
        };
        s.Close();
        WriteLine(message);

    }

}