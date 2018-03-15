using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            int sumOfdigits = 0;

            foreach (var num in numbers)
            {
               char [] digits= num.ToCharArray();
                digits=digits.Reverse().ToArray();
                int number = int.Parse(new string(digits));
                sumOfdigits += number;
                
            }
            
            Console.WriteLine(sumOfdigits);
        }
    }
}
