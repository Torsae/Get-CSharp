using Virtual_Pet;

var pet1 = new Pet("Bulbasaur", 1);
var pet2 = new Pet("Ivysaur", 2);
var pet3 = new Pet("Blastoise", 3);

Console.WriteLine("Which pet would you like to manage?:");
Console.WriteLine("1. Bulbasaur");
Console.WriteLine("2. Ivysaur");
Console.WriteLine("3. Blastoise");
var petChosen = Convert.ToInt32(Console.ReadLine());
if (petChosen == 1)
{
    pet1.ChoiceMenu();
}
else if (petChosen == 2)
{
    pet2.ChoiceMenu();
}
else if (petChosen == 3)
{
    pet3.ChoiceMenu();
}