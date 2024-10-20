using System.Diagnostics.Metrics;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scriptureText;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<Word> words = new List<Word>();
        string[] parsedText = text.Split(' ');
        foreach (var word in parsedText)
        {
            Word newWord = new Word(word);
            words.Add(newWord);
        }
        _scriptureText = words;
    }

    public void HideWords()
    {
        Random rnd = new Random();
        int counter = 0; 
        while (counter <= 3)
        {
            int randomNumber = rnd.Next(0, _scriptureText.Count);
            _scriptureText[randomNumber].HideWord();
            counter += 1;
        }
    }

    public string GetScripture()
    {
        string usableReference = _reference.GetReference();
        string scriptureText ="";
        foreach(var word in _scriptureText)
        {
            string usableWord = word.GetWord();
            scriptureText += usableWord + " ";
        }

        string completeScripture = usableReference + ": " + scriptureText;
        return completeScripture;
    
    }


}