using System;

namespace Foundation3
{
    public class Running : Activity
    {
        private double _distance;

        public Running(DateTime startTime, DateTime endTime, double distance) : base(startTime, endTime)
        {
            _distance = distance;
        }

        protected override double GetDistance()
        {
            return Math.Round(_distance, 2);
        }

        protected override double GetSpeed()
        {
            return Math.Round((_distance / _duration), 2);
        }

        protected override double GetPace()
        {
            return Math.Round(((_duration * 60) / _distance), 2);
        }
    }
}