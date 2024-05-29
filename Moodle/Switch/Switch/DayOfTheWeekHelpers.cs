internal static class DayOfTheWeekHelpers
{

    private static string ConvertIntToDay(int dayChosen)
    {
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
}