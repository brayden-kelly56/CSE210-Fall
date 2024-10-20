public class Reference
{
    private string _bookAndChapter;
    private int _verse;
    private int _endVerse;

    public Reference(string bookAndChap, int verse)
    {
        _bookAndChapter = bookAndChap;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string bookAndChap, int verse, int endVerse)
    {
        _bookAndChapter = bookAndChap;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_verse == _endVerse)
        {
            string completeReference = _bookAndChapter + ":" + _verse;
            return completeReference;
        }
        else
        {
            string completeReference = _bookAndChapter + ":" + _verse + "-" + _endVerse;
            return completeReference;
        }
    }
}