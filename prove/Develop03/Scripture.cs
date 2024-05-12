using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<string> _hiddenWords = new List<string>();
    private List<string> _shownWords = new List<string>();

    public Scripture(Reference Reference, String text)
    {
        _reference = Reference;
        string[] splitText = text.Split(" ");
        foreach (string word in splitText)
        {
            _shownWords.Add(word);
        }   
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new();
        
        for (int i = 0; i < numberToHide; i++)
        {
            int randoNumber = random.Next(_shownWords.Count());
            string removeWord = _shownWords[randoNumber];

            if (removeWord != "_____")
            {
                _hiddenWords.Add(removeWord);
            }
            if (removeWord == "_____")
            {
                randoNumber = random.Next(_shownWords.Count());
            }
        }
    }

    public string GetDisplayText()
    {
        string theReference = _reference.GetDisplayText();
        string theVerse = string.Join(" ", _words);

        return $"{theReference}\n {theVerse}";
    }

    public bool IsCompletelyHidden()
    {
        bool isAllHidden = false;
        bool finalResult = _shownWords.All(word => word == "_____");

        if (finalResult)
        {
            isAllHidden = true; 
        }
        
        return isAllHidden;
    }
}