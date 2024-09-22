using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your current grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        if (percentage >= 90)
        {
            Console.WriteLine("Your current grade is an A");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Your current grade is an B");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Your current grade is an C");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Your current grade is an D");
        }
        else
        {
            Console.WriteLine("Your current grade is an F");
        }
    }
}