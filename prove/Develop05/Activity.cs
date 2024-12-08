using System;

namespace Develop05
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        string[] _spinner = new string[] { "\\", "|", "/", "-" };
        int _spinnerIndex = 0;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = -1;
        }

        public int GetDuration()
        {
            return _duration;
        }

        protected void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to {_name} Activity.\n\n{_description}\n");
            Console.Write($"How long, in seconds, would you like for your session? ");

            while (_duration > 30 || _duration <= 4)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int duration) && duration <= 30 && duration > 4)
                {
                    _duration = duration;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number (5-30). ");
                }
            }

            Console.Clear();
            Console.WriteLine($"Get ready...\n");
            ShowSpinner(5);
        }

        protected void DisplayEndingMessage()
        {
            Console.WriteLine($"Well Done!");
            ShowSpinner(2);
            Console.WriteLine($"You completed another {_duration} seconds of the {_name} Activity.");
            ShowSpinner(5);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < (seconds * 4); i++)
            {
                Console.Write($"{_spinner[_spinnerIndex]}");
                System.Threading.Thread.Sleep(250);
                Console.Write("\b \b"); // Erase the last character
                if (_spinnerIndex == _spinner.Length - 1)
                {
                    _spinnerIndex = 0;
                }
                else
                {
                    _spinnerIndex++;
                }
            }
        }

        protected void ShowCountDown(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write($"{seconds - (i + 1)}");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the last character
                if (seconds == 0)
                {
                    break;
                }
            }
        }
    }
}