using  Objects_Classes;

var pikachu = new Pokemon("Pikachu", 50, 21);
var bulbasaur = new Pokemon("Bulbasaur", 34, 15);

Console.WriteLine("Choose a pokemon to Show their info:");
Console.WriteLine("0. Close application");
Console.WriteLine("1. Pikachu");
Console.WriteLine("2. Bulbasaur");
while (true)
{
    var userInput = Convert.ToInt32(Console.ReadLine());
    switch (userInput)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            pikachu.ShowInfo();
            break;
        case 2:
            bulbasaur.ShowInfo();
            break;
        default:
            RemoveLine.Run();
            Console.WriteLine("Invalid choice");
            break;
    }
}