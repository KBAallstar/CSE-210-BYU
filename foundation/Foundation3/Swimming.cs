using System;

namespace Foundation3
{
    public class Swimming : Activity
    {
        private double _laps;

        public Swimming(DateTime startTime, DateTime endTime, int laps) : base(startTime, endTime)
        {
            _laps = laps;
        }

        protected override double GetDistance()
        {
            return Math.Round((_laps * 50 / 1000), 2);
        }

        protected override double GetSpeed()
        {
            return Math.Round((GetDistance() / _duration), 2);
        }

        protected override double GetPace()
        {
            return Math.Round(((_duration * 60) / GetDistance()), 2);
        }
    }
}