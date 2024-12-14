using System;

namespace Develop06
{
    public class EternalGoal : SimpleGoal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
            Console.WriteLine("EternalGoal...");
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