public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public void ShowStartingMessage()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
    }

    public void ShowFinalMessage()
    {
        Console.WriteLine($"Congratulations, you completed the {_name} lasting {_duration} seconds!");
        ShowSpinner(5);
        Console.Clear();
    }

    public void ShowSpinner(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (currentTime < futureTime)
        {
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write(@"\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        currentTime = DateTime.Now;
        }
    }

    public void ShowCountdown(int duration)
    {
        while (duration >= 0)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            duration--;
        }
    }
}