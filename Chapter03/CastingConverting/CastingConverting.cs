using System;
using static System.Console;

public class CastingConverting
{
    public static void Main(string[] args)
    {
        int a = 10;
        double b = a;
        WriteLine(b);

        double c = 9.5;
        int d = c;
        WriteLine(d);
        // I was lazy to write more code, but in few words when you are trying to convert some time, cast only if you don't care on 100% number. Casting means you will lose number
        // from .9 ... or else and you will have bad result. 
    }
}