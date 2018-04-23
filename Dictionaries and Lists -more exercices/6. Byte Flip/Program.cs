using System;
using System.Linq;

namespace _6._Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Where(x => x.Length == 2)
                .Select(x => new string(x.Reverse().ToArray()))
                .Select(x => Convert.ToChar(Convert.ToInt32(x, 16)))
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join("", sequence));
        }
    }
}
