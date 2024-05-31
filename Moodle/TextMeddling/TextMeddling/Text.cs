using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextMeddling
{
    internal class Text
    {
        public void Run()
        {
            Console.WriteLine("Type the word you want to use:\n");
            var textToChange = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Type the number to choose an option: \n" +
                              "0: Close program \n" +
                              "1: Rotate text (ex: Cat = taC) \n" +
                              "2: Change word (replaces 'e' with 'a')\n");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var input))
                    if (input == 0) { Environment.Exit(0); }
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Result:" + RotateText(textToChange));
                        break;
                    case 2:
                        Console.WriteLine("Result:" + ChangeText(textToChange));
                        break;
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            }
        }

        private static string RotateText(string textToChange)
        {
            var reversedText = "";
            for (int i = textToChange.Length -1; i >= 0; i--)
            {
                reversedText += textToChange[i];
            }
            return reversedText;
        }

        private static string ChangeText(string textToChange)
        {
            return textToChange.Replace("a", "e");
        }
    }
}
