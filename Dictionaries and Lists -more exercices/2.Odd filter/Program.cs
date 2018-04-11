using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        for(int i=0; i<numbers.Count; i++)
        {
            if (numbers[i]%2==1)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }
        double numAverage = numbers.Average();
       for (int j=0; j<numbers.Count; j++)
        {
            if (numbers[j] > numAverage)
            {
                numbers[j]++;
                continue;
            }
            numbers[j]--;
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
    }
