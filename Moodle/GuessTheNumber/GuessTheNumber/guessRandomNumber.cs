using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class GuessRandomNumber
    {
        public int RandomNumber { get; set; }
        public void Run()
        {
            GenerateNumber();
            Console.WriteLine("Guess a number from 1-100: (999 to exit)");
            while (true)
            {
                var randomNumber = RandomNumber;
                if (int.TryParse(Console.ReadLine(), out var userInput))
                {
                    if (userInput == randomNumber)
                    {
                        WonGame();
                    }
                    else if (userInput > randomNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (userInput < randomNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Not a valid number.");
                } if (userInput == 999) { Environment.Exit(0); }
            }
        }

        private void WonGame()
        {
            Console.WriteLine("You guessed correctly! Would you like to play again? y/n");
            var playAgain = Console.ReadLine();
            if (playAgain == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                GenerateNumber();
            }
        }

        private void GenerateNumber()
        {
            var random = new Random();
            RandomNumber = random.Next(1, 100);
        }
    }
}
