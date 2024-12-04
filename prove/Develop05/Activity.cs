using System;

namespace Develop05
{
    public class Activity
    {
        string _name;
        string _description;
        int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Activity {_name}: {_description} for {_duration} seconds.");
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine($"test message.");
        }

        public void ShowSpinner(int seconds)
        {
            Console.Write("Working");
            for (int i = 0; i < seconds; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}