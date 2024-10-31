using System.Diagnostics.Metrics;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "Enter a duration for the activity and you will inhale and exhale with the given countdown timer provided.";
    }
    public void RunActivity()
    {
        ShowStartingMessage();
        Console.WriteLine("Enter the duration (in seconds) you would like to do this activity: ");
        _duration = Int32.Parse(Console.ReadLine());
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (currentTime < futureTime)
        {
            Console.Write($"Breathe In ");
            ShowCountdown(5);
            Console.Clear();
            Console.Write($"Breathe Out ");
            ShowCountdown(5);
            currentTime = DateTime.Now;
            Console.Clear();
        }
        ShowFinalMessage();
    }
}