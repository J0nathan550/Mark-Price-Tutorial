using System;
using static System.Console;

public class BitwiseAndShiftOperators
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 6;
        WriteLine($"a = {a}");
        WriteLine($"b = {b}");
        WriteLine($"a & b = {a & b}");
        WriteLine($"a | b = {a | b}");
        WriteLine($"a ^ b = {a ^ b}");
        WriteLine();
        WriteLine($"a << 3 = {a << 3}");
        WriteLine($"a * 8 = {a * 8}");
        WriteLine($"b >> 1 = {b >> 1}");
    }

}