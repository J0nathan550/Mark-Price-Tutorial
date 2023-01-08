using System;
using PacktLibrary;
using static System.Console;

public class Program
{
    public static void Main(string[] args)
    {
        Person bob = new Person();
        bob.Name = "Bob Smith";
        bob.DateOfBirth = new DateTime(1965, 12, 22);
        WriteLine("{0} was born on {1:dddd, d MMMM yyyy}", bob.Name, bob.DateOfBirth);
        Person alice = new Person(){
            Name = "Alice Jones",
            DateOfBirth = new DateTime(1998, 3, 7)
        };
        WriteLine("{0} was born on {1:dd MMMM, yyyy}", alice.Name, alice.DateOfBirth); // стр 196
    }

}