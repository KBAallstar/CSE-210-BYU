using System;

namespace Develop05
{
    public class ListingActivity : Activity
    {
        int _count;
        List<string> _prompts;

        public ListingActivity(string name, string description, int duration) : base(name, description, duration)
        {

        }

        public void Run()
        {
            Console.WriteLine("text");
        }

        public string GetRandomPrompt()
        {
            // return a random prompt
            return _prompts[0];
        }

        public List<string> GetListFromUser()
        {
            // get a list of prompts from the user
            return _prompts;
        }
    }
}