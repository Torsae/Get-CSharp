using System.Runtime.ExceptionServices;

namespace conditions
{

    internal class IfElse
    {
        public void ChooseNumbers()
        {
            Console.Clear();
            Console.WriteLine("Type two numbers ( A & B ) you would like to use:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            ChoiceMenu(firstNumber, secondNumber);
        }
        public void ChoiceMenu(int firstNumber, int secondNumber)
        {
            Console.Clear();
            Console.WriteLine($"Chosen numbers are: {firstNumber} and {secondNumber}.");
            Console.WriteLine("1: Check if A and B is equal.");
            Console.WriteLine("2: Multiply A and B if equal, add if not equal.");
            Console.WriteLine("3: Check if A, B, or sum is equal to or more than 30.");
            Console.WriteLine("4: Choose new numbers");
            Console.WriteLine("5: Close application");
            var userInput = Convert.ToInt32(Console.ReadLine());
            Redirect(userInput, firstNumber, secondNumber);
        }
        private void Redirect(int userInput, int firstNumber, int secondNumber)
        {
            if (userInput == 1) { CheckIfEqual(firstNumber, secondNumber); }
            else if (userInput == 2) { MultiplyIfEqual(firstNumber, secondNumber); }
            else if (userInput == 3) { EqualOrMoreThanThirty(firstNumber, secondNumber); }
            else if (userInput == 4) { ChooseNumbers(); }
            else if (userInput == 5) { Environment.Exit(0);}
            else
            {
                Console.WriteLine("Error: Not an option, choose again.");
                Console.ReadKey();
                ChoiceMenu(firstNumber, secondNumber);
            }
        }
        private void CheckIfEqual(int firstNumber, int secondNumber)
        {
            Console.Clear();
            Console.WriteLine($"Checking if {firstNumber} and {secondNumber} are equal..");
            Console.WriteLine(" ");
            Console.WriteLine(IsEqual(firstNumber, secondNumber)
                ? $"True: {firstNumber} and {secondNumber} are equal."
                : $"False: {firstNumber} and {secondNumber} are not equal.");
            Console.ReadKey();
            ChoiceMenu(firstNumber, secondNumber);
        }
        private void MultiplyIfEqual(int firstNumber, int secondNumber)
        {
            Console.Clear();
            var sumNumbers = firstNumber + secondNumber;
            Console.WriteLine($"Multiplying {firstNumber} and {secondNumber} if equal, adding if not equal.");
            Console.WriteLine(" ");
            Console.WriteLine(IsEqual(firstNumber, secondNumber)
                ? $"Chosen numbers are equal: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}"
                : $"Chosen numbers are not equal: {firstNumber} + {secondNumber} = {sumNumbers} ");
            Console.ReadKey();
            ChoiceMenu(firstNumber, secondNumber);
        }
        private bool IsEqual(int firstNumber, int secondNumber)
        {
            return firstNumber == secondNumber;
        }
        private void EqualOrMoreThanThirty(int firstNumber, int secondNumber)
        {
            Console.Clear();
            Console.WriteLine($"Checking if {firstNumber}, {secondNumber}, or sum is equal to or more than 30");
            var sumNumbers = firstNumber + secondNumber;
            Console.WriteLine(" ");
            Console.WriteLine(IsEqualToOrMoreThanThirty(firstNumber, secondNumber, sumNumbers)
                ? $"True: {firstNumber}, {secondNumber} or {sumNumbers} is equal to or greater than 30"
                : $"False: {firstNumber}, {secondNumber} or {sumNumbers} are not equal to or greater than 30");
            Console.ReadKey();
            ChoiceMenu(firstNumber, secondNumber);
        }
        private bool IsEqualToOrMoreThanThirty(int firstNumber, int secondNumber, int sumNumbers)
        {
            return firstNumber >= 30 || secondNumber >= 30 || sumNumbers >= 30;
        }
    }
}