using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multiplication Table Program.

            // Main variables:
            int multiplyOption;
            int numberToMult;
            int numberOfOperations;

            // Validation loops for user input:
            while (true)
            {
                Console.Write("Enter how many different numbers you'd like to multiply (maximum 10): ");
                multiplyOption = Convert.ToInt32(Console.ReadLine());

                if (multiplyOption > 10 || multiplyOption < 0)
                {
                    Console.WriteLine("Console.WriteLine(\"Invalid input. Please enter a number between 1 and 10.\");");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Enter how many times each number should be multiplied (maximum 10): ");
                numberOfOperations = Convert.ToInt32(Console.ReadLine());
                if (numberOfOperations > 10 || numberOfOperations < 0)
                {
                    Console.WriteLine("Console.WriteLine(\"Invalid input. Please enter a number between 1 and 10.\");");
                    continue;
                }
                break;
            }

            // Main program logic:
            for (int i = 1; i <= multiplyOption; i++)
            {
                Console.Write($"Enter number \"{i}\" to multiply: ");
                numberToMult = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                for (int j = 1; j <= numberOfOperations; j++)
                {
                    Console.WriteLine($"{numberToMult} * {j} = {numberToMult * j}");
                }
                Console.WriteLine();
            }

            // End of main program logic.
            Console.WriteLine("Multiplication table completed. Press any key to exit.");

            /* 
            ----- DISCLAIMER: -----
            This program assumes that the user always enters valid integer values.
            If a non-integer input is entered (e.g., a string), the program will crash.
            Input validation (e.g., using int.TryParse) is not yet implemented.
            */
        }
    }
}
