using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;

public class MethodCheck
{
    public static void Main(string[] args)
    {

        foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
        {
            var a = Assembly.Load(new AssemblyName(r.FullName));
            int methodCount = 0;

            foreach (var t in a.DefinedTypes)
            {
                methodCount += t.GetMethods().Count();
            }

            Console.WriteLine($"{a.DefinedTypes.Count()} types with {methodCount} methods in {r.Name} assembly.");
        }
    }

}