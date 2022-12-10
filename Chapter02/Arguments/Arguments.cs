using System;
using static System.Console;

namespace Arguments
{
    public class Arguments
    {
        private static void Main(string[] args)
        {
            bool isWorking = true;
            if (args.Length < 3)
            {
                WriteLine("You must specify two arguments of color, cursor size.");
                WriteLine("Example: dotnet run blue yellow 50");
                return;
            }
            ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
            BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);
            try
            {
                CursorSize = int.Parse(args[2]);
            }
            catch (PlatformNotSupportedException e)
            {
                WriteLine(e.Message);
            }
            while (isWorking)
            {
                string? test = ReadLine();
                if (test == "exit")
                {
                    isWorking = false;
                }
            }
        }
    }
}