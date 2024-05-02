using System;

public class Journal
    {
        public List<journalEntry> _entries = new List<journalEntry>();

        public void AddEntry(Entry newEntry) // Struggling with how to format this section
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (journalEntry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (journalEntry entry in _entries)
                {
                    string newLine = "Date: " + entry._date + " - Prompt: " + entry._prompt + "|" + entry._entryText;
                    outputFile.WriteLine(newLine);
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            string [] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');

                string dateAndPrompt = parts[0];
                string entry = parts[1];
            }
        }
    }