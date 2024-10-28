public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }
    public string GetWritingInformation()
    {
        string text = $"{_title} by {_studentName}";
        return text;
    }
}