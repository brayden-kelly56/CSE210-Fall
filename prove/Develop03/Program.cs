using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refer = new Reference("1 Nephi 2", 15);
        Scripture scriptureToMemorize = new Scripture(refer, "And my father dwelt in a tent.");
        bool cont = true;
        while (cont == true)
        {
            Console.WriteLine($"{scriptureToMemorize.GetScripture()}");

            Console.WriteLine("Press Enter to Continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                Console.WriteLine("Thank you for trying this program!");
                cont = false;
            }
            else
            {
                Console.Clear();
                scriptureToMemorize.HideWords();
            }
        }
    }
}