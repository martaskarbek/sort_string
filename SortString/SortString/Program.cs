using System;
using static System.Console;

namespace SortString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("\nBefore changes:\n");
            string str = "Microsoft .NET Framework 2.0 Application Development Foundation";
            WriteLine(str);
            WriteLine();
            string[] words = str.Split(' ');
            WriteLine("\nAfter split:\n");
            foreach (var word in words)
            {
                WriteLine(word);
            }
            Array.Sort(words);
            WriteLine("\nAfter sort:\n");
            foreach (var word in words)
            {
                WriteLine(word);
            }
            WriteLine("\nAfter join:\n");
            var s = string.Join(" ", words);
            Console.WriteLine(s);
        }
    }
}