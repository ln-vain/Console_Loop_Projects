using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higher;
            int triescount = 3;
            int userInput;

            Random rand = new Random();

            number = rand.Next(0, 201);

            lower = number - 10;
            if (lower < 0) lower = 0;
            lower = rand.Next(lower, number);

            higher = number + 10;
            if (higher > 100) higher = 100;
            higher = rand.Next(number + 1, higher);

            Console.WriteLine($"We quessed a number between 0 and 200. It's greater than {lower} and less than {higher}.");
            Console.WriteLine($"What is this number? You have 3 attemps.");
            Console.WriteLine();
            while (triescount-- > 0)
            {
                Console.Write("Your answer is: ");
                userInput = Convert.ToInt32(Console.ReadLine());


                if (userInput == number)
                {
                    Console.WriteLine("You guessed the number!");
                    break;
                }
                else
                {
                    Console.WriteLine("It's wrong number!");

                    if (userInput > number && userInput - number <= 5)
                    {
                        Console.WriteLine("But so close. Just a bit lower.");
                    }
                    else if (userInput < number && number - userInput <= 5)
                    {
                        Console.WriteLine("But so close. Just a bit higher.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong guess.");
                        Console.WriteLine();
                    }

                    Console.WriteLine($"You have \"{triescount}\" attempts left.");
                    Console.WriteLine();
                }

                if (triescount <= 0)
                {
                    Console.WriteLine($"You lost, but hope you'll be more lucky next time! The number was: \"{number}\"");
                }
            }
        }
    }
}
