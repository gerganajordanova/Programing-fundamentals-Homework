using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, double>> population = new Dictionary<string, Dictionary<string, double>>();
        string[] input = Console.ReadLine().Split('|').ToArray();
        while (input[0] != "report")
        {
            string country = input[1];
            string city = input[0];
            double pop = double.Parse(input[2]);

            if (!population.ContainsKey(country))
            {
                population.Add(country, new Dictionary<string, double> { { city, pop } });
            }

            if (!population[country].ContainsKey(city))
            {
                population[country].Add(city, pop);
            }

            input = Console.ReadLine().Split('|').ToArray();
        }

        PrintResult(population);
    }
    private static void PrintResult(Dictionary<string, Dictionary<string, double>> population)
    {
        var OrderedCountries = population.OrderByDescending(p => p.Value.Values.Sum());
        foreach (var pair in OrderedCountries)
        {
            var orderedCities = pair.Value.OrderByDescending(c => c.Value);

            Console.WriteLine($"{pair.Key} (total population: {pair.Value.Sum(c => c.Value)})");
            foreach (var city in orderedCities)
            {
                Console.WriteLine($"=>{city.Key}: {city.Value}");
            }
        }
    }
}
