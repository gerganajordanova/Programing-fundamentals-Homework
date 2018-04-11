using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<double, double>> productsData = new Dictionary<string, Dictionary<double, double>>();
        string[] data = Console.ReadLine().Split(' ');
        double totalAmount = 0.0;
        while (data[0] != "stocked")
        {
            string product = data[0];
            double price = double.Parse(data[1]);
            double quantity = double.Parse(data[2]);
            if (!productsData.ContainsKey(product))
            {
                productsData[product] = new Dictionary<double, double>();
            }
            if (!productsData[product].ContainsKey(price))
            {
                productsData[product][price] = 0;
            }
            productsData[product][price] += quantity;
            data = Console.ReadLine().Split(' ');
        }
        totalAmount = CalcTotalAmount(productsData, totalAmount);
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Grand Total: ${totalAmount:f2}");
    }

    private static double CalcTotalAmount(Dictionary<string, Dictionary<double, double>> productsData, double totalAmount)
    {
        foreach (var p in productsData)
        {
            string name = p.Key;
            double price = p.Value.Keys.Last();
            double quantity = p.Value.Values.Sum();
            totalAmount += quantity * price;

            Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${quantity * price:f2}");
        }

        return totalAmount;
    }
}