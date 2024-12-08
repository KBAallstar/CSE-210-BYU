using System;

namespace Develop05
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string> {
            "Think of a time you did something really difficult.",
            "Think of a time you felt really proud of yourself.",
            "Think of something you are looking forward to."
            };
        private List<string> _questions = new List<string> {
            "What did you learn from this experience?",
            "How did you feel when it was complete?",
            "What is your favorite thing about this experience?"
            };

        public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
        {

        }

        public void Run()
        {
            DisplayStartingMessage();
            DisplayPrompt();
            DisplayQuestion();
            DisplayQuestion();
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            int randomIndex = new Random().Next(0, _prompts.Count);
            return _prompts[randomIndex];
        }

        public string GetRandomQuestion()
        {
            int randomIndex = new Random().Next(0, _questions.Count);
            string question = _questions[randomIndex];
            _questions.RemoveAt(randomIndex);
            return question;
        }

        public void DisplayPrompt()
        {
            Console.WriteLine("Consider the following prompt:\n");
            Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
            Console.WriteLine("When you have something in mind, press ENTER to continue.\n");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("Invalid input. Press ENTER to continue.");
            }
            Console.Clear();
        }

        public void DisplayQuestion()
        {
            Console.Write("> ");
            Console.Write(GetRandomQuestion());
            ShowSpinner(5);
            Console.WriteLine();
        }
    }
}