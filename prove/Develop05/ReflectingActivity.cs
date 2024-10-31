using System.Security.Cryptography;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?" , "Have you ever done anything like this before?", "How did you feel when it was complete?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?"];

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void RunActivity()
    {
        Console.Clear();
        ShowStartingMessage();
        Console.WriteLine("Enter the time (in seconds) you would like to participate in this activity: ");
        _duration = Int32.Parse(Console.ReadLine());
        Console.Clear();
        ShowPrompt();
        Console.WriteLine("When you have an answer in mind press enter to proceed.");
        string temp = Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions as they appear:");
        ShowQuestions();
        ShowFinalMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, _prompts.Count);
        string prompt = _prompts[randomNumber];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, _questions.Count);
        string question = _questions[randomNumber];
        return question;
    }

    public void ShowPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void ShowQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (currentTime < futureTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(10);
            currentTime = DateTime.Now;
        }
    }
}