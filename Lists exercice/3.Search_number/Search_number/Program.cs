using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int [] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> newNums = new List<int>();
            int numsToTake = commands[0];
            int numsToDelete = commands[1];
            int searchedNum = commands[2];
            newNums.AddRange(nums.Take(numsToTake));
            newNums.RemoveRange(0, commands[1]);
            if (newNums.Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }


        }
    }
}
