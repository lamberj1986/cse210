using System;

public class Journal
    {
        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    string newLine = "Date: " + entry._date + " - Prompt: " + entry._promptText + "|" + entry._entryText;
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