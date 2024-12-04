using System;

namespace Develop05
{
    public class ReflectingActivity : Activity
    {
        List<string> _prompts;
        List<string> _questions;

        public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
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

        public string GetRandomQuestion()
        {
            // return a random question
            return _questions[0];
        }

        public void DisplayPrompt()
        {
            Console.WriteLine(GetRandomPrompt());
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(GetRandomQuestion());
        }
    }
}