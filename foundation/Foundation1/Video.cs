using System.Diagnostics.Metrics;
using System.Net;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        string title = _title;
        return title;
    }

    public string GetAuthor()
    {
        string author = _author;
        return author;
    }

    public int GetLength()
    {
        int length = _length;
        return length;
    }

    public void DisplayVideoInfo()
    {
        string title = GetTitle();
        string author = GetAuthor();
        int length = GetLength();
        int numberOfComments = GetNumberOfComments();

        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length (in seconds): {length}");
        Console.WriteLine($"# of Comments: {numberOfComments}");
        foreach (Comment comment in _comments)
        {
            string newComment = comment.DisplayComment();
            Console.WriteLine("");
            Console.WriteLine($"{newComment}");
            Console.WriteLine("");
        }
    }

    public void AddComment(string commenter, string text)
    {
        Comment newComment = new Comment(commenter, text);
        _comments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        int commentCount = 0;
        foreach (var comment in _comments)
        {
            commentCount += 1;
        }

        return commentCount;
    }
}