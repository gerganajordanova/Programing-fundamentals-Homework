﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string[] commands = Console.ReadLine().Split().ToArray();
            while (commands[0] != "END")
            {
                if (commands[0] == "A")
                {
                    string name = commands[1];
                    string phone = commands[2];

                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phone;
                    }
                    else
                    {
                        phonebook.Add(name, phone);
                    }
                }
                if (commands[0] == "S")
                {
                    string name = commands[1];
                    if (phonebook.ContainsKey(name))
                    {
                        foreach (var n in phonebook.Where(x => x.Key == name))
                        {
                            Console.WriteLine($"{n.Key} -> {n.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                if (commands[0]=="ListAll")
                {
                    foreach (var p in phonebook)
                    {
                        Console.WriteLine($"{p.Key} -> {p.Value}");
                    }
                }
                commands = Console.ReadLine().Split().ToArray();
            }

        }
    }
}


