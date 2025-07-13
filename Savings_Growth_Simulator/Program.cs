using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savings_Growth_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Main variables.
            float money;
            int years;
            int percent;
            int oldBalance;

            // Entering variables.
            Console.Write("Enter the deposite amount (In Dollars): ");
            money = Convert.ToSingle(Console.ReadLine());
            
            Console.Write("Enter the duration of deposit (In Years): ");
            years = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the interest rate (%): ");
            percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            

            // Main calculation and output.
            for (int i = 1; i <= years; i++)
            {
                oldBalance = (int)money;

                money += money / 100 * percent;
                Console.WriteLine($"Your balance is: {money} in \"{i}\" year.");
                Console.WriteLine($"Your interest for this year is: {money / 100 * percent}.");
                Console.WriteLine($"Your income is {money - oldBalance}" + " Dollars.");

                Console.WriteLine();
                Console.WriteLine("Press Enter to see the amount for the next year.");
                Console.WriteLine();
                Console.ReadKey();
            }

            // Final message
            Console.WriteLine("Thank you for using our banking service.");
        }
    }
}
