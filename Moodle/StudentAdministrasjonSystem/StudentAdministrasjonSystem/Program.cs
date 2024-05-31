using StudentAdministrationSystem;

Main();
return;
void Main()
{
    Student steve = new(1, "Steve", 22, "English");
    Student alan = new(2, "Alan", 23, "History");
    Subject english = new(1, "English", 10);
    Subject history = new(2, "History", 12);
    Grade steveGrade = new(steve, english);
    Grade alanGrade = new(alan, history);

    Console.WriteLine("Choose an option:\n" +
                      "1. Print student info: Steve\n" +
                      "2. Print student info: Alan\n" +
                      "3. Print subject info: English\n" +
                      "4. Print subject info: History\n" +
                      "5. Print Steve's grade info.\n" +
                      "6. Print Alan's grade info.\n" +
                      "0. Close application\n");
    while (true)
    {
        var userInput = Convert.ToInt32(Console.ReadLine());
        RemoveLine.Run();
        switch (userInput)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                steve.PrintInfo();
                break;
            case 2:
                alan.PrintInfo();
                break;
            case 3:
                english.PrintInfo();
                break;
            case 4:
                history.PrintInfo();
                break;
            case 5:
                steveGrade.PrintInfo();
                break;
            case 6:
                alanGrade.PrintInfo();
                break;
            default:
                RemoveLine.Run();
                Console.WriteLine("\n Invalid choice \n");
                break;
        }
    }
}