namespace Develop02
{
    public class Entry
    {
        public string _Date = "";
        public string _promptText = "";
        public string _entryText = "";

        public Entry(string date, string prompt, string entry)
        {
            _Date = date;
            _promptText = prompt;
            _entryText = entry;
        }

        public void Display()
        {
            Console.Write($"Date: {_Date} - ");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
        }
    }
}