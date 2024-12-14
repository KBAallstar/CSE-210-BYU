using System;

namespace Develop06
{
    public class SimpleGoal : Goal
    {
        protected bool _isComplete = false;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            Console.WriteLine("SimpleGoal...");
        }

        public override void RecordEvent()
        {
            Console.WriteLine("SimpleGoal.RecordEvent...");
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public string GetDetailsString()
        {
            return $"{_shortName} - {_description} - {_points}";
        }

        public string GetStringRepresentation()
        {
            return $"{_shortName} - {_description} - {_points}";
        }
    }
}