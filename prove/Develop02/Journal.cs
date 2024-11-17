using System;
using System.IO;

namespace Develop02
{
    public class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddNewEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayAllEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries to display.");
                return;
            }
            else
            {
                Console.WriteLine("~ ~ ~ ALL CURRENT JOURNAL ENTRIES ~ ~ ~");
                foreach (Entry entry in _entries)
                {
                    entry.Display();
                    Console.WriteLine(" ");
                }
            }
        }

        public void SaveToFile(string userFileName)
        {
            // Save all entries to a text file.
            if (_entries.Count == 0)
            {
                Console.WriteLine("No entries to save.");
                return;
            }
            else
            {
                using (StreamWriter outputFile = new StreamWriter(userFileName + ".txt"))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry._Date}||{entry._promptText}||{entry._entryText}");
                    }

                    Console.WriteLine($"Entries saved to {userFileName}.txt");
                }
            }
        }

        public void LoadFromFile(string userFileName)
        {
            // Load entries from a text file.
            string[] lines = File.ReadAllLines(userFileName + ".txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split("||");

                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                _entries.Add(entry);
            }

            Console.WriteLine($"Entries loaded from {userFileName}.txt");
        }
    }
}