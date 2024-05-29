using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class DayOfTheWeek ()
    {
        public void Run()
        {
            Console.WriteLine("Type '0' to close program");
            Console.WriteLine("Type a number between 1-7 to get the corresponding day:");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var dayChosen))
                {
                    ClearLastLine();
                    Console.WriteLine($"Day {dayChosen} = {ConvertIntToDay(dayChosen)}");
                }
                else { Console.WriteLine("Error: Parsing failed."); }
            }
        }

        private static string ConvertIntToDay(int dayChosen)
        {
            if (dayChosen == 0) { Environment.Exit(0); }
            return dayChosen switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "Error: Not a valid number."
            };
        }

        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}
