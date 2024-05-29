using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHobbyGenerator
{
    internal class RandomGenerator
    {
        public void MainMenu()
        {
            while (true)
            {
                Console.WriteLine("Type 'Exit' to close program");
                Console.WriteLine("Who would like a new hobby?");
                var chosenName = Console.ReadLine();
                if (chosenName == "Exit") { Environment.Exit(0);}
                else
                {
                    Console.WriteLine("Generating hobby..");
                    Console.WriteLine($"{chosenName} {GenerateRandomHobby()}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        private string GenerateRandomHobby()
        {
            var randomHobby = RandomNumber(_hobbyList.Count);
            return GetHobbyFromList(randomHobby);
        }

        private int RandomNumber(int input)
        {
            var randomNumber = new Random();
            return randomNumber.Next(0, input);
        }

        private string GetHobbyFromList(int input)
        {
            return _hobbyList[input];
        }

        private readonly List<string> _hobbyList =
        [
            "is now a magician. Poof, magic!",
            "is now an official toad-licker. Sorry",
            "is now a hobby slacker. Slothie",
            "is now a log avoider. Don't tell anyone!",
            "is now an avid shoe-shiner. Clean!"
        ];
    }
}
