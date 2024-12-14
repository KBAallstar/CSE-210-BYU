using System;

namespace Develop06
{
    public class ChecklistGoal : SimpleGoal
    {
        int _amountCompleted;
        int _target;
        int _bonus;

        public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
        {
            _shortName = name;
            _description = description;
            _points = points;
            _amountCompleted = amountCompleted;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                SetIsComplete(true);
                Console.WriteLine($"Goal {_shortName} is complete! You earned {_points += _bonus} points!");
            }
            else
            {
                Console.WriteLine($"Goal {_shortName} is {_amountCompleted}/{_target} complete! You earned {_points} points!");
            }
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
            return $"{completionBox} {_shortName}: {_description}. Value: {_points}. -- Currently completed: {_amountCompleted}/{_target}. Bonus: {_bonus}.";
        }

        public override string GetStringRepresentation()
        {
            return $"Checklist//{_isComplete}//{_shortName}//{_description}//{_points}//{_amountCompleted}//{_target}//{_bonus}";
        }

        public int GetAmountCompleted()
        {
            return _amountCompleted;
        }

        public int GetTarget()
        {
            return _target;
        }
    }
}