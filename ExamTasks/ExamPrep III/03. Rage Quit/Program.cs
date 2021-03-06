﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class RageQuit
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();

            Regex regex = new Regex(@"(\D+)(\d+)");

            MatchCollection matches = regex.Matches(input);

            var uniqueCharacters = new HashSet<char>();
            StringBuilder outputResult = new StringBuilder();
            foreach (Match match in matches)
            {
                string message = match.Groups[1].Value;
                int repeat = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < repeat; i++)
                {
                    outputResult.Append(message);
                }
            }
            Console.WriteLine($"Unique symbols used: {outputResult.ToString().Distinct().Count()}");
            Console.WriteLine(outputResult);
        }
    }
