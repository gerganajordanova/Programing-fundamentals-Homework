using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string snowflakePattern = @"^([^A-Za-z\d]+)    
([\d_]+)
((?:[^A-Za-z\d]+)(?:[\d_]+)(?<core>[a-zA-Z]+)(?:[\d_]+)(?:[^A-Za-z\d]+))
([\d_]+)
([^A-Za-z\d]+)$";

            List<string> inputs = new List<string>();
            string input = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                input = Console.ReadLine();

                inputs.Add(input);
            }

            string result = $@"{inputs[0]}
{inputs[1]}
{inputs[2]}
{inputs[3]}
{inputs[4]}";

            if (Regex.IsMatch(result, snowflakePattern))
            {
                Match match = Regex.Match(result, snowflakePattern);
                int coreLength = match.Groups["core"].Value.Length;
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }