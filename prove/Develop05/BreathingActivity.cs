using System;

namespace Develop05
{
    public class BreathingActivity : Activity
    {
        private int _breathInDuration = 4;
        private int _breathOutDuration = 6;

        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
        {

        }

        public void Run()
        {
            DisplayStartingMessage();
            PerformBreathingExercise(GetDuration());
            DisplayEndingMessage();
        }

        private void PerformBreathingExercise(int seconds)
        {
            int totalReps = (int)Math.Ceiling((float)seconds / (float)(_breathInDuration + _breathOutDuration));

            for (int i = 0; i < totalReps; i++)
            {
                Console.Write("Breathe in... ");
                ShowCountDown(_breathInDuration);
                Console.WriteLine();
                Console.Write("Breathe out... ");
                ShowCountDown(_breathOutDuration);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}