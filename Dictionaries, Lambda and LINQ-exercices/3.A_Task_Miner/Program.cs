using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.A_Task_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string command = Console.ReadLine();
            int quantity = 0;
            while (command != "stop")
            {
                quantity = int.Parse(Console.ReadLine());
                if (resources.ContainsKey(command))
                {
                    resources[command] += quantity;
                }
                else
                {
                    resources.Add(command, quantity);
                }
                command = Console.ReadLine();
            }
            foreach(var material in resources)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }
        }
    }
}
