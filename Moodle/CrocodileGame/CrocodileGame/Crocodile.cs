using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrocodileGame
{
    internal class Crocodile
    {
        private int _playerScore = 0;
        public void Run() {
            while (true)
            {
                int[] randomNumbers = GenerateRandomNumbers();
                Console.WriteLine($"{randomNumbers[0]} _ {randomNumbers[1]}");
                var answer = Console.ReadLine();
                if (answer != ">" && answer != "=" && answer != "<")
                {
                    Console.WriteLine("You failed, thank you for playing.");
                    Console.WriteLine($"Your final score was: {_playerScore}");
                    Console.WriteLine("Would you like to restart? y/n");
                    if (Console.ReadLine() == "y")
                    {
                        Console.Clear();
                        _playerScore = 0;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else if (CompareNumbers(randomNumbers, answer))
                {
                    Console.WriteLine("Success!");
                    _playerScore++;
                    Console.WriteLine("You gained points: +1");
                    Console.WriteLine($"Current score is: {_playerScore}");
                }
                else
                {
                    Console.WriteLine("Failure");
                    _playerScore--;
                    Console.WriteLine("You lost points: -1");
                    Console.WriteLine($"Current score is: {_playerScore}");
                }
            }
        }
        private int[] GenerateRandomNumbers()
        { 
            return [new Random().Next(1, 11), new Random().Next(1, 11)];
        }
        private bool CompareNumbers(int[] randomNumbers, string answer)
        {
            return randomNumbers[0] < randomNumbers[1] && answer == "<" ||
                   randomNumbers[0] == randomNumbers[1] && answer == "=" ||
                   randomNumbers[0] > randomNumbers[1] && answer == ">";
        }
    }
}
