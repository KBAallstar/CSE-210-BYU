using System;

namespace Develop05
{
    public class ListingActivity : Activity
    {
        int _count = 0;
        private List<string> _prompts = new List<string> {
            "How have you felt the Holy Ghost this month?",
            "What are some of the best things that happened to you this week?",
            "What are some of the greatest blessings in your life right now?"
            };

        public ListingActivity(string name, string description, int duration) : base(name, description, duration)
        {

        }

        public void Run()
        {
            DisplayStartingMessage();
            ListActivity();
            DisplayEndingMessage();
        }

        private void ListActivity()
        {
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
            Console.Write("Countdown to begin: ");
            ShowCountDown(6);
            Console.WriteLine();
            GetListFromUser(GetDuration());
            Console.WriteLine($"You listed {_count} items!");
        }

        public string GetRandomPrompt()
        {
            int randomIndex = new Random().Next(0, _prompts.Count);
            return _prompts[randomIndex];
        }

        public List<string> GetListFromUser(int timer)
        {

            List<string> responses = new List<string>();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(timer);

            while (DateTime.Now <= endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                responses.Add(response);
            }

            _count = responses.Count;

            return responses;
        }
    }
}