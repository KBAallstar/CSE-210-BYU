using System;

namespace Develop06
{
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public virtual void RecordEvent()
        {
            Console.WriteLine("Goal.RecordEvent...");
        }

        public abstract bool IsComplete();

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