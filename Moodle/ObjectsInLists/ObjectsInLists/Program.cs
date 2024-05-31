using ObjectsInLists;

Person damon = new Person("Damon", 23);
Person sean = new Person("Sean", 25);
Console.WriteLine("Old list:");
Person.PrintList();
Console.WriteLine("Would you like to add Damon and Sean to the list?");
Console.WriteLine("1: Yes, add to list and print");
Console.WriteLine("2: No, close application");
while (true)
{
    if (int.TryParse(Console.ReadLine(), out var userInput))
    {
        switch (userInput)
        {
            case 1:
                RemoveLine.Run();
                Console.WriteLine(" ");
                Console.WriteLine("New List:");
                Person.AddPeople(damon);
                Person.AddPeople(sean);
                Person.PrintList();
                break;
            case 2:
                RemoveLine.Run();
                Environment.Exit(0);
                break;
            default:
                RemoveLine.Run();
                Console.WriteLine("Invalid input");
                break;
        }
    }
}