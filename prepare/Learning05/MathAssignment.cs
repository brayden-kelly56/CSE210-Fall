public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string section, string problems)
    {
        _studentName = studentName;
        _topic = topic;
        _textbookSection = section;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        string text = $"{_textbookSection} {_problems}";
        return text;
    }
}