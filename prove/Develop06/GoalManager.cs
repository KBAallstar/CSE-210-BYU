using System;

namespace Develop06
{
    public class GoalManager
    {
        List<Goal> _goals = new List<Goal>();
        int _score = 0;

        public GoalManager()
        {
            Console.WriteLine("GoalManager...");
        }
    }
}