using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> dragonData = new Dictionary<string, Dictionary<string, int[]>>();
            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();
                string type = data[0];
                string name = data[1];
                int damage = 45;
                int health = 250;
                int armor = 10;
                if (data[2] != "null")
                {
                    damage = int.Parse(data[2]);
                }
                if (data[3] != "null")
                {
                    health = int.Parse(data[3]);
                }
                if (data[4] != "null")
                {
                    armor = int.Parse(data[4]);
                }
                if (dragonData.ContainsKey(type))
                {
                    if (dragonData[type].ContainsKey(name))
                    {
                        dragonData[type][name][0] = damage;
                        dragonData[type][name][1] = health;
                        dragonData[type][name][2] = armor;
                    }
                    else
                    {
                        dragonData[type].Add(name, new int[] { damage, health, armor });
                    }
                }
                else
                {
                    dragonData.Add(type, new Dictionary<string, int[]> { { name, new int[] { damage, health, armor } } });
                }

            }
            PrintData(dragonData);
        }

        private static void PrintData(Dictionary<string, Dictionary<string, int[]>> dragonData)
        {
            foreach (var type in dragonData)
            {
                double averageDamage = type.Value.Select(x => x.Value[0]).Average();
                double averageHealth = type.Value.Select(x => x.Value[1]).Average();
                double averageArmor = type.Value.Select(x => x.Value[2]).Average();
                Console.WriteLine($"{type.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}

