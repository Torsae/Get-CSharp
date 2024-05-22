using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    internal class Pet
    {
        public string? Name { get; private set; }
        public int Age { get; private set; }
        public int Food { get; private set; }
        public int Poop { get; private set; }
        public int Mood { get; private set; }

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
            Food = RandomValue(80, 100);
            Poop = RandomValue(80, 100);
            Mood = RandomValue(80, 100);
        }

        private int RandomValue(int minValue, int maxValue)
        {
            var random = new Random();
            return random.Next(minValue, maxValue);
        }

        public void ChoiceMenu()
        {
            while (true)
            {
                Console.WriteLine("Choice menu:");
                Console.WriteLine($"1. Feed {Name}");
                Console.WriteLine($"2. Cuddle with your {Name}");
                Console.WriteLine($"3. Walk the {Name} (poop)");
                Console.WriteLine("4. Exit game");
                var choiceMade = Convert.ToInt32(Console.ReadLine());
                if (choiceMade == 1)
                {
                    FeedPet();
                }
                else if (choiceMade == 2)
                {
                    Cuddle();
                }
                else if (choiceMade == 3)
                {
                    WalkPet();
                }
                else if (choiceMade == 4)
                {
                    Environment.Exit(0);
                }
                FinishedAction(choiceMade);
            }
        }

        private void FeedPet()
        {
            Console.WriteLine($"Food:{Food} + 15 = {Food += 15}");
            Console.WriteLine($"Mood:{Mood} + 5 = {Mood += 5}");
        }

        private void Cuddle()
        {
            Console.WriteLine($"Mood:{Mood} + 15 = {Mood += 15}");
        }

        private void WalkPet()
        {
            Console.WriteLine($"Mood:{Poop} + 15 = {Poop += 15}");
        }

        private void FinishedAction(int choiceMade)
        {
            Console.WriteLine("Action made: Random stat changes");
            if (choiceMade == 1)
            {
                Console.WriteLine($"Mood reduced to: {Mood -= RandomValue(10, 20)}");
                Console.WriteLine($"Poop reduced to: {Poop -= RandomValue(10, 20)}");
            }
            else if (choiceMade == 2)
            {
                Console.WriteLine($"Food reduced to: {Food -= RandomValue(10, 20)}");
                Console.WriteLine($"Poop reduced to: {Poop -= RandomValue(10, 20)}");
            }
            else if (choiceMade == 3)
            {
                Console.WriteLine($"Food reduced to: {Food -= RandomValue(10, 20)}");
                Console.WriteLine($"Mood reduced to: {Mood -= RandomValue(10, 20)}");
            }
        }
    }
}
