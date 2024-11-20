using System;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<Word> _visibleWords = new List<Word>();
    private string[] _text;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text.Split(' ');
        foreach (var word in _text)
        {
            _words.Add(new Word(word));
        }
        CalculateVisibleWords();
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        CalculateVisibleWords();

        for (int i = 0; i < numberToHide && _visibleWords.Count > 0; i++)
        {
            var wordToHide = _visibleWords[random.Next(_visibleWords.Count)];
            wordToHide.Hide();
            _visibleWords.Remove(wordToHide);
        }
    }

    public string GetDisplayText()
    {
        var displayText = new StringBuilder();

        foreach (var word in _words)
        {
            displayText.Append(word.GetDisplayText());
            displayText.Append(" ");
        }

        return displayText.ToString();
    }

    public bool IsCompletelyHidden()
    {
        if (_visibleWords.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void ShowAllVisibleWords()
    {
        foreach (var word in _visibleWords)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
    }

    private void CalculateVisibleWords()
    {
        _visibleWords.Clear();

        foreach (var word in _words)
        {
            if (word.IsHidden())
            {
                continue;
            }
            else
            {
                _visibleWords.Add(word);
            }
        }
    }
}