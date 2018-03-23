using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    private static int CalculatePoints(string card)
    {
        string power = card[0].ToString();
        string type = card[card.Length - 1].ToString();
        int powerAsNumber = 0;
        int typeAsNumber = 0;
        bool nPower = int.TryParse(power, out powerAsNumber);

        if (power == "1")
        {
            power = "10";
        }

        if (nPower == false)
        {
            switch (power)
            {
                case "J":
                    powerAsNumber = 11;
                    break;
                case "Q":
                    powerAsNumber = 12;
                    break;
                case "K":
                    powerAsNumber = 13;
                    break;
                case "A":
                    powerAsNumber = 14;
                    break;
            }
        }
        else
        {
            switch (type)
            {
                case "S":
                    typeAsNumber = 4;
                    break;
                case "H":
                    typeAsNumber = 3;
                    break;
                case "D":
                    typeAsNumber = 2;
                    break;
                case "C":
                    typeAsNumber = 1;
                    break;
            }
        }

        int calcCardPoints = powerAsNumber * typeAsNumber;
        return calcCardPoints;
    }

    static void Main(string[] args)
    {
        Dictionary<string, int> scores = new Dictionary<string, int>();
        Dictionary<string, string> people = new Dictionary<string, string>();
        string[] input = Console.ReadLine().Split(':').ToArray();
        string name = input[0];
        string hand = input[1];
        int sumOfHand = 0;

        while (name != "JOKER")
        {
            if (people.ContainsKey(name))
            {
                people[name] += hand;
            }
            else
            {
                people.Add(name, hand);
            }

        }

        foreach (var p in people)
        {
            List<string> playerCards = new List<string>();
            playerCards = p.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();

            foreach (string card in playerCards)
            {
                sumOfHand += CalculatePoints(card);
            }

            if (scores.ContainsKey(p.Key))
            {
                scores[p.Key] += sumOfHand;
            }
            else
            {
                scores.Add(p.Key, sumOfHand);
            }
        }

        foreach (var result in scores)
        {
            Console.WriteLine($"{result.Key}: {result.Value}");
        }
    }
}

