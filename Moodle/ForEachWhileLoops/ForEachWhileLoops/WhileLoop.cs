using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWhileLoops
{
    internal class WhileLoop
    {
        public void Run()
        {
            PrintToConsole();
        }

        private static void PrintToConsole()
        {
            bool condition = true;
            int i = 0;
            while (condition)
            {
                if (i < 10)
                {
                    Console.WriteLine($"Round #{i} what");
                    i++;
                }
                else
                {
                    condition = false;
                    ClearLine.Run();
                }
            }
        }
    }
}
