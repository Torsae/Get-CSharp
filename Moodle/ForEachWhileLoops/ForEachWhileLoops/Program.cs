using ForEachWhileLoops;

var option1 = new ForLoop();
var option2 = new ForEachLoop();
var option3 = new WhileLoop();

Console.WriteLine("Choose a loop: (0 to exit)");
Console.WriteLine("1. For-Loop");
Console.WriteLine("2. ForEach-Loop");
Console.WriteLine("3. While-Loop");
while (true)
{
    Console.WriteLine("");
    if (int.TryParse(Console.ReadLine(), out var userInput))
    {
        switch (userInput)
        {
            case 0:
                ClearLine.Run();
                Environment.Exit(0);
                break;
            case 1:
                ClearLine.Run();
                option1.Run();
                break;
            case 2:
                ClearLine.Run();
                option2.Run();
                break;
            case 3:
                ClearLine.Run();
                option3.Run();
                break;
            default:
                Console.WriteLine("Error: Not a valid option:");
                break;
        }
    }
    else { Console.Write("Error: parsing failed!"); }
}