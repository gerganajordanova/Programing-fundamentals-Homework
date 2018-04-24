using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
                List<int> sequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

                List<int> losers = new List<int>();

                while (sequence.Count != 1)
                {
                    for (int index = 0; index < sequence.Count; index++)
                    {
                        if (Math.Abs(losers.Count - sequence.Count) == 1)
                        {
                            continue;
                        }

                        if (losers.Contains(index))
                        {
                            continue;
                        }

                        int attackerIndex = index;
                        int targteIndex = ValidIndex(sequence[attackerIndex], sequence.Count);
                        int absoluteValue = Math.Abs(attackerIndex - targteIndex);

                        if (absoluteValue == 0)
                        {
                            Console.WriteLine($"{attackerIndex} performed harakiri");
                            losers.Add(attackerIndex);
                            losers = losers.Distinct().ToList();
                        }

                        if (absoluteValue != 0 && absoluteValue % 2 == 0)
                        {
                            Console.WriteLine($"{attackerIndex} x {targteIndex} -> {attackerIndex} wins");
                            losers.Add(targteIndex);
                            losers = losers.Distinct().ToList();
                        }

                        if (absoluteValue % 2 == 1)
                        {
                            Console.WriteLine($"{attackerIndex} x {targteIndex} -> {targteIndex} wins");
                            losers.Add(attackerIndex);
                            losers = losers.Distinct().ToList();
                        }
                    }

                    foreach (var index in losers.OrderByDescending(x => x).Distinct())
                    {
                        sequence.RemoveAt(index);
                    }

                    losers.Clear();
                }
            }

        private static int ValidIndex(int index, int lenght)
        {
            if (index >= lenght)
            {
                index = index % lenght;
            }
            return index;
        }


    }