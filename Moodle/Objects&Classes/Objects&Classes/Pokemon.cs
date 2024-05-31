using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Classes
{
    internal class Pokemon(string name, int health, int level)
    {
        public string Name { get; set; } = name;
        public int Health { get; set; } = health;
        public int Level { get; set; } = level;

        public void ShowInfo()
        {
            RemoveLine.Run();
            Console.WriteLine($"{Name} is level {Level} and has {Health} health.");
        }
    }
}