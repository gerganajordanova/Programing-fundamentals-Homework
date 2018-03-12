using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char [] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            
            string[] commands = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            while(commands[0]!="Even" && commands[0]!="Odd")
            {
                if (commands[0] == "Even")
                {
                    foreach (var n in numbers.Where(x => x % 2 == 0))
                    {
                        Console.WriteLine(string.Join(" ", n));
                    }
                }
                else if (commands[0] == "Odd")
                {
                    foreach (var n in numbers.Where(x => x % 2 != 0))
                    {
                        Console.WriteLine(string.Join(" ", n));
                    }
                }
                else if (commands[0] == "Delete")
                {
                    
                }
                else
                {

                }
            }
        }
    }
}
