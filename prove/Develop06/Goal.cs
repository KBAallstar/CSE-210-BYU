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

        public abstract void RecordEvent();

        public abstract bool IsComplete();
        public abstract void SetIsComplete(bool isComplete);

        public virtual string GetDetailsString()
        {
            return $"{_shortName}: {_description}. Value: {_points}.";
        }

        public abstract string GetStringRepresentation();

        public string GetShortName()
        {
            return _shortName;
        }

        public int GetPoints()
        {
            return _points;
        }
    }
}