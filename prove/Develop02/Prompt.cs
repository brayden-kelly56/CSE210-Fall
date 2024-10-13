public class Prompt
{
    public string[] _listPrompts = ["Who was the most interesting person I interacted with today?",
    "What was the best part of my day?","How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"];

    public string getRandomPrompt(string[] listPrompts)
    {
        Random rnd = new Random();
        int entry = rnd.Next(0, 4);
        string prompt = listPrompts[entry];
        return prompt;
    }
}