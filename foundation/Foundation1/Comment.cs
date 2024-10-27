using System.ComponentModel.DataAnnotations.Schema;

public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }

    public string GetCommenter()
    {
        string commenter = _commenter;
        return commenter;
    }

    public string GetText()
    {
        string text = _text;
        return text;
    }

    public string DisplayComment()
    {
       string commenter = GetCommenter();
       string text = GetText();
       string comment = commenter + " : " + text;
       return comment;
    }
}