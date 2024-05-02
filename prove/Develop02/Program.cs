// As a team we decided to add a new method to allow the user to add 
// to the prompt list. I accomplished this with option #5 from the menu.

using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal newJournal = new Journal();
        PromptGenerator newPrompt = new PromptGenerator();
        
        int choice = 0;

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Add new Prompt");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            string strChoice = Console.ReadLine();
            choice = int.Parse(strChoice);

            if (choice == 1) // Write
            {
                Entry anEntry = new Entry();
                PromptGenerator aPrompt = new PromptGenerator();

                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();

                anEntry._date = dateText;
                anEntry._promptText = aPrompt.GetRandomPrompt();
                
                Console.WriteLine(anEntry._promptText);
                string userInput = Console.ReadLine();
                anEntry._entryText = userInput;

                newJournal.AddEntry(anEntry);            
            }
            else if (choice == 2) // Display
            {
                newJournal.DisplayAll();
            }
            else if (choice == 3) // Load
            {
                Console.WriteLine("What is the file name to load?");
                string fileName = Console.ReadLine();

                newJournal.LoadFromFile(fileName);
            }
            else if (choice == 4) // Save
            {
                Console.WriteLine("What is the file name to save?");
                string fileName = Console.ReadLine();

                newJournal.SaveToFile(fileName);
            }
            else if (choice == 5) // Add new prompt
            {
                Console.WriteLine("What is the new prompt?");
                string newUserPrompt = Console.ReadLine();

                newPrompt.AddNewPrompt(newUserPrompt);
            }

        } while (choice != 6);
    }
}