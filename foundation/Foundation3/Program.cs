using System;

namespace Foundation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Activity runningActivity = new Running(new DateTime(2022, 11, 03, 10, 0, 0), new DateTime(2022, 11, 03, 10, 30, 0), 4.8);
            runningActivity.GetSummary();

            Activity cyclingActivity = new Cycling(new DateTime(2022, 11, 03, 10, 0, 0), new DateTime(2022, 11, 03, 10, 30, 0), 20);
            cyclingActivity.GetSummary();

            Activity swimmingActivity = new Swimming(new DateTime(2022, 11, 03, 10, 0, 0), new DateTime(2022, 11, 03, 10, 30, 0), 40);
            swimmingActivity.GetSummary();
        }
    }
}