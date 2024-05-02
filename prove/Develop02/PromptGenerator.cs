// Added a new method to this class to allow the user to add a new prompt.
// This was a part of my going above and beyond.

using System;

public class PromptGenerator
    {
        public List<string> _prompts = new List<string> 
            {
                "Who was the most interesting persion I interacted with today?", 
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What was one of the things you learned today?",
                "What your prodest accomplishments from the day today?"
            };

        public string GetRandomPrompt()
        {
            Random randomGenerator = new Random();
            int length = _prompts.Count;
            int promptNumber = randomGenerator.Next(1,length) - 1;

            string randomPrompt = _prompts[promptNumber];

            return randomPrompt;
        }

        public void AddNewPrompt(string newPrompt)
        {
            _prompts.Add(newPrompt);
        }
    }