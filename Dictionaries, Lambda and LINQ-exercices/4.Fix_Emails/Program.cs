using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string names = Console.ReadLine();
            while (names != "stop")
            {
                string email = Console.ReadLine();
                if(emails.ContainsKey(names))
                {
                    emails[names] = email;
                }
                else
                {
                    emails.Add(names, email);
                }
                names = Console.ReadLine();
            }
            foreach(var person in emails.Where(p=>!p.Value.EndsWith("us") && !p.Value.EndsWith("uk")))
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
           
        }
    }
}
