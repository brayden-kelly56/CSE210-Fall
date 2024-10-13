public class Entry
{
    public string _date;
    public string _question;

    public string _response;

    public string getDate()
    {
        DateTime today = DateTime.Today;

        string date = today.ToString("MM/dd/yyyy");
        return date;
    }

    public string getUserResponse(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        return response;
    }

    public void saveEntry(Entry journalEntry)
    {
        
    }
}