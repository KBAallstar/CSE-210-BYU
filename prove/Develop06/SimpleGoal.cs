using System;

namespace Develop06
{
    public class SimpleGoal : Goal
    {
        protected bool _isComplete = false;

        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public override void RecordEvent()
        {
            SetIsComplete(true);
            Console.WriteLine($"Goal {_shortName} is complete! You earned {_points} points!");
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            string completionBox = "[ ]";
            if (IsComplete())
            {
                completionBox = "[X]";
            }
            return $"{completionBox} {_shortName}: {_description}. Value: {_points}.";
        }

        public override string GetStringRepresentation()
        {
            return $"Simple//{_isComplete}//{_shortName}//{_description}//{_points}";
        }

        public override void SetIsComplete(bool isComplete)
        {
            _isComplete = isComplete;
        }
    }
}