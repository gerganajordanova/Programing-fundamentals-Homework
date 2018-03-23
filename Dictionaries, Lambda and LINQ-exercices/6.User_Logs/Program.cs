using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split().ToArray();
            while(input[0]!="end")
            {
                string ip = input[0].Substring(3);
                string user = input[2].Substring(5);
                if (users.ContainsKey(user))
                {
                   if(users[user].ContainsKey(ip))
                    {
                        users[user][ip]+= 1;
                    }
                    else
                    {
                        users[user].Add(ip, 1);
                    }
                }
                else
                {
                    users.Add(user, new Dictionary<string, int> { { ip, 1 } });
                }
                input = Console.ReadLine().Split().ToArray();
            }
            PrintResult(users);
        }
        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> users)
        {
           
          foreach (KeyValuePair<string, Dictionary<string, int>> u in users)
            {
            Console.WriteLine($"{u.Key}: ");
            int counter = 0;
                foreach (var prop in u.Value)
                {
                    Console.Write($"{prop.Key} => {prop.Value}");
                    if (counter < u.Value.Count - 1)
                    {
                        Console.Write(", ");
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                }
            }
        }
    }

