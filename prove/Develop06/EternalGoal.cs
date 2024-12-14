using System;

namespace Develop06
{
    public class EternalGoal : SimpleGoal
    {
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"Goal {_shortName} is complete! You earned {_points} points!");
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetStringRepresentation()
        {
            return $"Eternal//{_isComplete}//{_shortName}//{_description}//{_points}";
        }
    }
}