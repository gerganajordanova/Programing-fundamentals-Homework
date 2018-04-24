using System;
using System.Globalization;


namespace _1.SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            decimal Totalprice = 0;
            for (int i=0; i<countOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal currentPrice = (daysInMonth * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
                Totalprice += currentPrice;
            }
            Console.WriteLine($"Total: ${Totalprice:f2}");
        }
    }
}
