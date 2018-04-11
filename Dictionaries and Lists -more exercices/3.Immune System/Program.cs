using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int startHealth = int.Parse(Console.ReadLine());
        int health = startHealth;
        List<string> virusesList = new List<string>();

        health = VirusMethod(startHealth, health, virusesList);
        if (health > 0) Console.WriteLine($"Final Health: {health}");
        else Console.WriteLine($"Immune System Defeated.");

    }

    private static int VirusMethod(int startHealth, int currentHealth, List<string> virusesList)
    {
        while (currentHealth > 0)
        {
            string input = Console.ReadLine();
            int virusStrenght = 0;
            int time = 0;

            if (input == "end") break;


            if (!virusesList.Contains(input))
            {
                virusesList.Add(input);
                for (int i = 0; i < input.Length; i++)
                {
                    virusStrenght += input[i];
                }
                virusStrenght = virusStrenght / 3;
                time = virusStrenght * input.Length;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    virusStrenght += input[i];
                }
                virusStrenght = virusStrenght / 3;
                time = virusStrenght * input.Length / 3;
            }

            currentHealth -= time;
            int minutes = time / 60;
            int seconds = time - minutes * 60;

            Console.WriteLine($"Virus {input}: {virusStrenght} => {time} seconds");
            if (currentHealth <= 0) break;
            Console.WriteLine($"{input} defeated in {minutes}m {seconds}s.");
            Console.WriteLine($"Remaining health: {currentHealth}");

            currentHealth += currentHealth * 20 / 100;
            if (currentHealth > startHealth)
            {
                currentHealth = startHealth;
            }
        }

        return currentHealth;
    }
}