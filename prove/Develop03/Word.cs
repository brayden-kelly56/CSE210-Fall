public class Word
{
    private string _word;
    private bool _isVisable;

    public Word(string word)
    {
        _word = word;
        _isVisable = true;
    }

    public void HideWord()
    {
        _isVisable = false;
        int space = _word.Length;
            int count = 0;
            _word = "";
            while (count < space)
            {
                _word += "_";
                count += 1;
            }
    }

    public bool IsVisable()
    {
        if (_isVisable == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetWord()
    {
        bool visable = IsVisable();

        if (visable == true)
        {
            string text = _word;
            return text;
        }
        else
        {
            HideWord();
            string text = _word;
            return text;
        }
    }
}