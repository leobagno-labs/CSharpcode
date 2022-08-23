using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalculation
{
    internal class Program
    {
              
        public static void solve(double mealCost, int tipPercent, int taxPercent)
        {
        

            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            double totalCost = mealCost + tip + tax;

            Console.WriteLine("The total meal cost is "  + Math.Round(totalCost) + " dollars.");

        }

        static void Main(string[] args)
        {

            solve(12.00, 20, 8);
            Console.ReadLine();
        }
    }
}