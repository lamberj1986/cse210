    using System;

    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();
        private List<string> _shownWords = new List<string>();
        private List<int> _hiddenWordIndes = new List<int>();

        private Random _random = new Random();

        public Scripture(Reference Reference, String text)
        {
            _reference = Reference;
            string[] splitText = text.Split(" ");
            foreach (string wordText in splitText)
            {
                Word newWord = new Word(wordText);
                _words.Add(newWord);
                _shownWords.Add(wordText);
            }   
        }

        public void HideRandomWords(int numberToHide)
        {
            numberToHide = Math.Min(numberToHide, _words.Count - _hiddenWordIndes.Count);
            
            for (int i = 0; i < numberToHide; i++)
            {
                int randoNumber;

                do
                {
                    randoNumber = _random.Next(_words.Count);
                } while (_hiddenWordIndes.Contains(randoNumber));

                _words[randoNumber].Hide();
                _hiddenWordIndes.Add(randoNumber);
            }
        }

        public string GetDisplayText()
        {
            string theReference = _reference.GetDisplayText();
            
            List<string> displayedWords = new List<string>();
            
            foreach (Word word in _words)
            {
                if(word.IsHidden())
                {
                    displayedWords.Add("_____");
                }
                else
                {
                    displayedWords.Add(word.GetDisplayText());
                }
            }

            string theVerse = string.Join(" ", displayedWords);

            if(IsCompletelyHidden())
            {
                theVerse += "\nCongrats! You have memorized the entire verse.";
            }

            return $"{theReference}\n {theVerse}";
        }

        public bool IsCompletelyHidden()
        {
           return _words.All(word => word.IsHidden());
        }
    }