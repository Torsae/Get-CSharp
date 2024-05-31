using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatDoesThisCodeDo
{
    internal class WhatDoesThisDo
    {
        public void Run()
        {
            var range = 250;
            var counts = new int[range];
            int totalLetters = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Write anything to run application");
                Console.WriteLine("Leave empty to close application");
                text = Console.ReadLine() ?? string.Empty;
                if (text == "") { Environment.Exit(0); }
                foreach (var character in text.ToLower())
                {
                    totalLetters++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var percentage = 100 * (int)counts[i] / totalLetters;
                        var output = character + " - " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}
