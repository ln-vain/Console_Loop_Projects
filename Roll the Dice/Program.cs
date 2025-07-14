using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roll_the_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is a simple dice rolling game where the player has 3 attempts to roll a sum of 12.
            // If the player rolls a sum of 12, they win; otherwise, they lose after 3 attempts.
            // The game uses random number generation to simulate the rolling of two dice.


            // Main variables:
            int firstDice;
            int secondDice;
            int diceSum;

            int throwCount = 3;
            Random rand = new Random();

            // Game introduction.
            Console.WriteLine("Welcome to our casino!");
            Console.WriteLine("You are rolling dice. You have 3 attempts! If you get 12, you WIN!");
            Console.WriteLine();
            Console.WriteLine("Press Enter to roll:");
            Console.ReadKey();
            Console.WriteLine();


            // Game loop for rolling the dice.
            for (int i = 1; i <= throwCount; i++)
            {
                Console.WriteLine($"Roll #{i}");

                firstDice = rand.Next(1, 7);
                Console.WriteLine($"Dice 1: {firstDice}");

                secondDice = rand.Next(1, 7);
                Console.WriteLine($"Dice 2: {secondDice}");

                diceSum = firstDice + secondDice;
                Console.WriteLine($"Total sum: {diceSum}");
                Console.WriteLine();

                if (diceSum == 12)
                {
                    Console.WriteLine("Congratulations! You won.");
                    return;
                }

                Console.WriteLine($"You have {throwCount - i} attempts left.");

                if (diceSum != 12 && i == throwCount)
                {
                    Console.WriteLine("Unfortunately, you didn't win. Try again!");
                    return;
                }
                Console.ReadKey();
            }
            
        }
    }
}
