using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            Solve(meal_cost, tip_percent, tax_percent);

            Console.ReadLine();
        }

        static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = ((meal_cost * tip_percent)/100);
            double tax = ((meal_cost * tax_percent) / 100);
            var totalCost = meal_cost + tax + tip;
            Console.WriteLine("The total meal cost is {0} dollars.", Math.Round(totalCost) );
        }
    }
}
