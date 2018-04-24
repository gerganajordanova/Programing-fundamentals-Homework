using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = -1;
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int snowballSnow  = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow  / snowballTime), snowballQuality);
                if (snowballValue > maxValue)
                {
                    result = String.Format("{0} : {1} = {2} ({3})", snowballSnow , snowballTime, snowballValue, snowballQuality);
                    maxValue = snowballValue;
                }
            }
            Console.WriteLine(result);
        }
    }
}
