using System;

/*
    Exceeds expectations by doing the following:
    - Created helpful titles for each menu option
    - Check to see if save files exist before loading them
    - Check to see if goals are completed before allowing the user to record an event
*/

namespace Develop06
{
    class Program
    {
        public static GoalManager goalManager = new GoalManager();

        static void Main(string[] args)
        {
            goalManager.Start();

            string userChoice = "-1";
            while (userChoice != "6")
            {
                Console.Clear();
                DisplayMenu();
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    goalManager.DisplayNewGoalMenu();
                }
                else if (userChoice == "2")
                {
                    goalManager.ListGoalDetails();
                }
                else if (userChoice == "3")
                {
                    goalManager.SaveGoals();
                }
                else if (userChoice == "4")
                {
                    goalManager.LoadGoals();
                }
                else if (userChoice == "5")
                {
                    goalManager.RecordEvent();
                }
                else if (userChoice == "6")
                {
                    Console.WriteLine("~~~ USER QUIT PROGRAM ~~~");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select an appropriate number.");
                }
            }
        }

        public static void DisplayMenu()
        {
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create new Goal");
            Console.WriteLine("   2. List current Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Type a number to select an option from the menu: ");
        }
    }
}
