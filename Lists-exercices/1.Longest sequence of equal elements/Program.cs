using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List <int> LongestSequence = new List<int>();
            int MaxIndex= 0;
            int BestLength = 1;
            int CurrentIndex = 0;
            int CurrentLength= 1;
            

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    CurrentLength++;
                }

                else
                {
                    CurrentIndex = i;
                    CurrentLength = 1;
                }
                if (BestLength<CurrentLength)
                {
                    BestLength = CurrentLength;
                    MaxIndex = CurrentIndex;
                }
                
            }
            for (int j = 0; j < BestLength; j++)
            {
                LongestSequence.Add(numbers[MaxIndex + j]);
            }
            Console.WriteLine(string.Join(" ", LongestSequence));
        }
    }
}
