using System;

namespace Foundation3
{
    public abstract class Activity
    {
        protected DateTime _startTime;
        protected DateTime _endTime;
        protected double _duration;

        public Activity(DateTime startTime, DateTime endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
            _duration = (endTime - startTime).TotalHours;
        }

        protected abstract double GetDistance();

        protected abstract double GetSpeed();

        protected abstract double GetPace();

        public void GetSummary()
        {
            Console.WriteLine($"{_startTime.Day} {_startTime.Month} {_startTime.Year} (30 min)- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
        }
    }
}