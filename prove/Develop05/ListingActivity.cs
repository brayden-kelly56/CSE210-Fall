public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = ["Who are people you appreciate?", "What are personal strengths of yours?", "Who are people you have helped this week?", "When have you felt the Holy Ghost this Month?", "Who are some of your personal heroes?"];

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void RunActivity()
    {
        Console.Clear();
        ShowStartingMessage();
        Console.WriteLine("Enter the time (in seconds) you would like to spend on this activity:");
        _duration = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Your prompt is:");
        GetRandomPrompt();
        Console.WriteLine("");
        ShowCountdown(5);
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"Nice work! You listed {_count} items in your list!");
        Thread.Sleep(5000);
        ShowFinalMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[randomNumber]);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (currentTime < futureTime)
        {
            string userInput = Console.ReadLine();
            userList.Add(userInput);
            currentTime = DateTime.Now;
        }   
        return userList; 
    }
}