using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ForEachLoop
    {
        public void Run()
        {
            PrintToConsole();
            //Console.ReadKey();
        }

        private static void PrintToConsole()
        {
            string[] args = new string[] { "This ", "is ", "fun " };
            foreach (var arg in args)
            {
                Console.Write(arg);
            }
        }
    }
}