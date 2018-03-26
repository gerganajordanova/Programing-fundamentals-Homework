
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> partiesData = new Dictionary<string, Dictionary<string, int>>();
           
            while (true)
            {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            string correctInputPattern = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";
                if (Regex.IsMatch(input, correctInputPattern))
                {
                    Match match = Regex.Match(input, correctInputPattern);
                    string singer = match.Groups[1].Value.Trim();
                    string place = match.Groups[3].Value.Trim();
                    int ticketsPrice = int.Parse(match.Groups[5].Value);
                    int ticketsCount = int.Parse(match.Groups[6].Value);
                    int totalPrice = ticketsPrice * ticketsCount;

                    if (!partiesData.ContainsKey(place))
                    {
                        partiesData.Add(place, new Dictionary<string, int>() { { singer, totalPrice } });
                    }
                    else if (!partiesData[place].ContainsKey(singer))
                    {
                        partiesData[place].Add(singer, totalPrice);
                    }
                    else
                    {
                        partiesData[place][singer] += totalPrice;
                    }
                }
            }

        foreach (var party in partiesData)
            {
                Console.WriteLine(party.Key);

            foreach (var singer in party.Value.OrderByDescending(s=>s.Value))
                {
                    Console.WriteLine("#  {0} -> {1}",singer.Key,singer.Value);
                }
            }
        }
    }
