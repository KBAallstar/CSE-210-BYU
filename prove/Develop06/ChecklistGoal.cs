using System;

namespace Develop06
{
    public class ChecklistGoal : SimpleGoal
    {
        int _amountCompleted;
        int _target;
        int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            Console.WriteLine("ChecklistGoal...");
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