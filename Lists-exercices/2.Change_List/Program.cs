using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<string> commands = Console.ReadLine().ToLower().Split().ToList();

        while (commands[0] != "odd" && commands[0] != "even")
        {
            if (commands[0] == "delete")
            {
                int removeElement = int.Parse(commands[1]);
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == removeElement)
                    {
                        nums.Remove(removeElement);
                        i--;
                    }
                }
            }
            else
            {
                int number = int.Parse(commands[1]);
                int Index = int.Parse(commands[2]);
                nums.Insert(Index, number);
            }

            commands = Console.ReadLine().ToLower().Split().ToList();
        }

        if (commands[0] == "odd")
        {

            foreach (var n in nums.Where(x => x % 2 == 1))
            {
                Console.Write(n + " ");
            }

        }
        else
        {
            foreach (var n in nums.Where(x=>x% 2==0))
            {
                Console.Write(n + " ");
            }
        }
    }
}