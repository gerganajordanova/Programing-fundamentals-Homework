using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] commands = Console.ReadLine().ToLower().Split().ToArray();
            while(commands[0]!="print")
            {
                if(commands[0]=="add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);
                    numbers.Insert(index, element);

                }
                if (commands[0]=="addmany")
                {
                    int index = int.Parse(commands[1]);
                    List<int> element = commands.Skip(2).Select(int.Parse).ToList(); 
                    numbers.InsertRange(index,element);
                }
                if (commands[0]=="contains")
                {
                    int element = int.Parse(commands[1]);
                    Console.WriteLine(numbers.IndexOf(element));
           
                }
                if(commands[0]=="remove")
                {
                   int index=int.Parse(commands[1]);
                    numbers.RemoveAt(index);
                }
                if(commands[0]=="shift")
                {
                    int positions = int.Parse(commands[1]);
                    for (int i = 0; i < positions; i++)
                    {
                        int lastElement = numbers[0];
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            numbers[j] = numbers[j + 1];
                        }
                        numbers[numbers.Count - 1] = lastElement;
                    }

                }
                if(commands[0]=="sumpairs")
                {
                    List<int> newList = new List<int>();
                    for (int i = 0; i < numbers.Count - 1; i += 2)
                    {
                        newList.Add(numbers[i] + numbers[i + 1]);
                    }
                    if (numbers.Count % 2 == 1)
                    {
                        newList.Add(numbers[numbers.Count - 1]);
                    }
                    numbers = newList;
                }
                commands = Console.ReadLine().ToLower().Split().ToArray();
            }
           
                Console.WriteLine("["+string.Join(", ",numbers)+"]");
            
        }
    }
}
