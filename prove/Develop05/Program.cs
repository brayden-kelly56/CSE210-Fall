using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();
        bool cont = true;
        while(cont == true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an activity: ");
            string choice = Console.ReadLine();
            int number = Int32.Parse(choice);

            if (number == 1)
            {
                breathing.RunActivity();
            }
            else if (number == 2)
            {
                listing.RunActivity();
            }
            else if (number == 3)
            {
                reflecting.RunActivity();
            }
            else if (number == 4)
            {
                Console.WriteLine("Thank you for completing the mindfulness activity!");
                cont = false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that choice, please enter the number for your preferred option.");
                Thread.Sleep(3000);
            }
        }
    }
}