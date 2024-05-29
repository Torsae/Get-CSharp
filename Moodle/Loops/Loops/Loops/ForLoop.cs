using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class ForLoop
    {
        public void Run()
        {
            PrintToConsole();
            //Console.ReadKey();
        }

        private static void PrintToConsole()
        {
            string[] args = new string[] { "Terje ", "is ", "cool" };
            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(args[i]);
            }
        }
    }
}
