using System;

namespace Develop05
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
        {

        }

        public void Run()
        {
            Console.WriteLine("text");
        }
    }
}