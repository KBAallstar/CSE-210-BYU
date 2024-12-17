using System;

namespace Foundation3
{
    public class Cycling : Activity
    {
        private double _speed;

        public Cycling(DateTime startTime, DateTime endTime, double speed) : base(startTime, endTime)
        {
            _speed = speed;
        }

        protected override double GetDistance()
        {
            return Math.Round((_duration * _speed), 2);
        }

        protected override double GetSpeed()
        {
            return Math.Round(_speed, 2);
        }

        protected override double GetPace()
        {
            return Math.Round(((_duration * 60) / GetDistance()), 2);
        }
    }
}