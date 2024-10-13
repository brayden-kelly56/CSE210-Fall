using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.display_menu();
        Console.WriteLine("What would you like to do (Enter number)? ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            Prompt prompt = new Prompt();
            Entry newEntry = new Entry();
            newEntry._date = newEntry.getDate();
            newEntry._question = prompt.getRandomPrompt(prompt._listPrompts);
            
        }
        else if (option == "2")
        {

        }
        else if (option == "3")
        {

        }
        else if (option == "4")
        {

        }
        else if (option == "5")
        {

        }
        else
        {

        }
    }
}