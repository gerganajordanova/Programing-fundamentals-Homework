using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Legendary_farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> materials = new Dictionary<string, long>();
            Dictionary<string, long> junk = new Dictionary<string, long>();
            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;
            bool getMat = true;
            string obtained = "";
            while (getMat)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                for (int i = 0; i < input.Count; i = i + 2)
                {
                    long quantity = long.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (materials.ContainsKey(material))
                    {
                        materials[material] += quantity;
                        if (materials[material] >= 250)
                        {
                            obtained = material;
                            materials[material] -= 250;
                            getMat = false;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(material))
                        {
                            junk[material] += quantity;
                        }
                        else
                        {
                            junk.Add(material, quantity);
                        }
                    }
                }
            }
       
            switch (obtained)
            {
                case "motes":
                Console.WriteLine("Dragonwrath obtained!");
                    break;
                case "fragments": Console.WriteLine("Valanyr obtained!");
                    break;
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
            }
            foreach(var mat in materials.OrderBy(x=>x.Key).OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }
            foreach (var material in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
