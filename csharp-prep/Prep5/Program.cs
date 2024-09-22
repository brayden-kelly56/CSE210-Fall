using System;

class Program
{
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Name and Number Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int Number = Console.Read();
        return Number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(int square, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(square, name);
    }
}
