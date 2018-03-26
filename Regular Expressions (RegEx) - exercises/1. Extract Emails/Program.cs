using System;
using System.Text.RegularExpressions;

namespace _1.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s|^)([a-z0-9]+(?:[_.-][a-z0-9]+)*@(?:[a-z]+\-?[a-z]+\.)+[a-z]+\-?[a-z]+)\b";
            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine($"{m.Value}");
            }
        }
    }
}
