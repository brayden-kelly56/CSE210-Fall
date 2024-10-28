public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public string GetSummary()
    {
        string info = $"{_studentName} - {_topic}";
        return info;
    }
}