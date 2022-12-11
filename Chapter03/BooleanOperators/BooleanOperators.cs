using System;
using static System.Console;

public class BooleanOperators
{
    public static void Main(string[] args)
    {
        bool a = true;
        bool b = false;

        WriteLine($"AND     | a            |b     ");
        WriteLine($"a       | {a | a}         |b {a & b} ");
        WriteLine($"b       | {b | a}         |b {b & b} ");
        WriteLine();
        WriteLine($"OR      | a            |b     ");
        WriteLine($"a       | {a | a}         |b {a | b} ");
        WriteLine($"b       | {b | a}         |b {b | b} ");
        WriteLine();
        WriteLine($"XOR     | a            |b     ");
        WriteLine($"a       | {a ^ a}        |b {a ^ b} ");
        WriteLine($"b       | {b ^ a}         |b {b ^ b} ");
        WriteLine();
        WriteLine($"a & ExampleFunction() = {a & ExampleFunction()}");
        WriteLine($"b & ExampleFunction() = {b & ExampleFunction()}");
        WriteLine($"a & ExampleFunction() = {a && ExampleFunction()}");
        WriteLine($"b & ExampleFunction() = {b && ExampleFunction()}");
    }

    private static bool ExampleFunction()
    {
        WriteLine("Just for the test of boolean function.");
        return true;
    }

}