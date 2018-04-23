using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            string pattern = @"([A-Z]{2})([0-9]{4})([A-Z]{2})";
                Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string operation = input[0];
                string user = input[1];

                if (operation == "register")
                {
                    string plate = input[2];

                    if (users.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[user]}");
                    }
                    else if (!regex.IsMatch(plate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plate}");
                    }
                    else if (users.ContainsValue(plate))
                    {
                        Console.WriteLine($"ERROR: license plate {plate} is busy");
                    }
                    else
                    {
                        users.Add(user, plate);
                        Console.WriteLine($"{user} registered {plate} successfully");
                    }

                }
                else if (operation == "unregister")
                {
                    if (users.ContainsKey(user))
                    {
                        users.Remove(user);
                        Console.WriteLine($"user {user} unregistered successfully");                       
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }

            }
            foreach (var u in users)
            {
                Console.WriteLine($"{u.Key} => {u.Value}");
            }
        }
    }
}
