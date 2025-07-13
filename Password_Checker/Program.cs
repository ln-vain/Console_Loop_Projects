using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Main variables.
            int triesCount = 5;
            string password = "12345";
            string userInput;


            // ---- Loop for checking password. ---- //

            for (int i = 1; i <= triesCount; i++)
            {
                // Prompt user for input.
                Console.Write("Enter the password: ");
                userInput = Console.ReadLine();

                // Check if the input matches the password.
                if (userInput == password)
                {
                    Console.WriteLine("Welcome!");
                    break;
                }
                else
                {
                    // If the input does not match, inform the user and show remaining attempts.
                    if (i < triesCount)
                    {
                        Console.WriteLine($"Wrong Password. You have {triesCount - i} attempts left.");
                    }
                    else
                    {
                        Console.WriteLine("You have no more attempts left.");
                    }
                }
            }

        }
    }
}
