using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {}

    public void start()
    {
        bool cont = true;
        while (cont == true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Option:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a Choice from the Menu:");
            int optionNumber = Int32.Parse(Console.ReadLine());
            if (optionNumber == 1)
            {
                CreateGoal();
            }
            else if (optionNumber == 2)
            {
                ListGoalDetails();
            }
            else if (optionNumber == 3)
            {
                SaveGoals();
            }
            else if (optionNumber == 4)
            {
                LoadGoals();
            }
            else if (optionNumber == 5)
            {
                RecordEvent();
            }
            else if (optionNumber == 6)
            {
                cont = false;
            }
            else
            {
                Console.WriteLine("Please Enter a valid option");
                Console.Clear();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine(" ");
    }

    public void ListGoalDetails()
    {
        int increment = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{increment}. {goal.GetDetailsString()}");
            increment++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Enter the number of the goal you would like to create: ");
        int goalSelect = Int32.Parse(Console.ReadLine());
        if (goalSelect == 1)
        {
            Console.WriteLine("What is the name of the goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("Give the goal a brief description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter a point value for completing the goal: ");
            string points = Console.ReadLine();
            _goals.Add(new SimpleGoal(name, description, points));
            Console.WriteLine("Your goal has been added!");
        }
        else if (goalSelect == 2)
        {
            Console.WriteLine("What is the name of the goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("Give the goal a brief description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter a point value for completing the goal: ");
            string points = Console.ReadLine();
            _goals.Add(new EternalGoal(name, description, points));
            Console.WriteLine("Your goal has been added!");
        }
        else if (goalSelect == 3)
        {
            Console.WriteLine("What is the name of the goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("Give the goal a brief description: ");
            string description = Console.ReadLine();
            Console.WriteLine("Enter a point value for completing the goal: ");
            string points = Console.ReadLine();
            Console.WriteLine("How many times must the goal be completed? ");
            int target = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What will the final bonus points for completion be? ");
            int bonus = Int32.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            Console.WriteLine("Your goal has been added!");

        }
        else
        {
            Console.WriteLine("Not a valid number for goal type, please try again");
        }
    }

    public void RecordEvent()
    {
        Console.Clear();
        ListGoalDetails();
        Console.WriteLine("Enter the number of the goal you have acheived:");
        int goalSelect = Int32.Parse(Console.ReadLine());
        try
        {
            int points = _goals[goalSelect - 1].RecordEvent();
            _score += points;
        }
        catch
        {
            Console.WriteLine("The goal was unable to be found, please try again.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter a file name: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"{_score}");
                foreach(Goal goal in _goals)
                {
                    outputFile.WriteLine($"{goal.GetStringRepresentation()}");
                }
            }
    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter a file name: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                string isComplete = parts[4];
                SimpleGoal temp = new SimpleGoal(name, description, points);
                if (isComplete == "true")
                {
                    temp.IsComplete();
                }
                _goals.Add(temp);
            }
            else if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int bonus = Int32.Parse(parts[4]);
                int target = Int32.Parse(parts[5]);
                int amountCompleted = Int32.Parse(parts[6]);
                ChecklistGoal tempCheck = new ChecklistGoal(name, description, points, target, bonus);
                int counter = 0;
                while (counter < amountCompleted)
                {
                    tempCheck.RecordEvent();
                    counter++;
                }
                _goals.Add(tempCheck);
            }
            else
            {
                _score = Int32.Parse(parts[0]);
            }
        }
    }
}