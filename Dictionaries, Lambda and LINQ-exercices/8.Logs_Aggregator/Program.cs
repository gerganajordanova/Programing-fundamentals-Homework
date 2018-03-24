using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        
        Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
        string[] input = Console.ReadLine().Split().ToArray();
       for (int i=0; i<count; i++)
        {
            string ip = input[0];
            string name = input[1];
            int numbers = int.Parse(input[2]);
            if (logs.ContainsKey(name))
            {
                if (logs[name].ContainsKey(ip))
                {
                    logs[name][ip] += numbers;
                }
                else
                {
                    logs[name].Add(ip, numbers);
                }
            }
            else
            {
                logs.Add(name, new Dictionary<string, int> { { ip, numbers } });
            }
            input = Console.ReadLine().Split().ToArray();
           
        }
        PrintResult(logs);
    }
    private static void PrintResult(Dictionary<string, Dictionary<string, int>> logs)
    {

         foreach (var user in logs.OrderBy(x => x.Key))
        {
            Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
            int commaCounter = 0;
            foreach (var data in user.Value.OrderBy(x => x.Key))
            {
                Console.Write($"{data.Key}");
                if (commaCounter < user.Value.Count - 1)
                {
                    Console.Write(", ");
                    commaCounter++;
                }
                else
                {
                    Console.WriteLine("]");
                }
            }
        }

    }
}
