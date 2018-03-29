using System;
using System.Text.RegularExpressions;
    class Program
    {
        static void Main(string[] args)
        {
            string wordToMatch = Console.ReadLine().Trim();
            string pattern = $@"(\b{wordToMatch}\b)";
            string [] text=Console.ReadLine().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sentence in text)
            {
                Match match = Regex.Match(sentence, pattern);

                if (match.Success)
                {
                    Console.WriteLine(sentence);
                }

            }
        }
    }
