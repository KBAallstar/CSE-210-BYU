using System;

/*
    Tyler Hatton
    Exceeded requirements:
    - Made sure the questions in the ReflectingActivity class are not repeated.
    - Made sure the activity duration was between 5 and 30 seconds.
    - Made sure the BreathingActivty lasted the full set duration.
*/

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "-1";

            while (userChoice != "4")
            {
                Console.Clear();
                DisplayMenu();
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 1);
                    breathingActivity.Run();
                }
                else if (userChoice == "2")
                {
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 1);
                    reflectingActivity.Run();
                }
                else if (userChoice == "3")
                {
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 1);
                    listingActivity.Run();
                }
                else if (userChoice == "4")
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
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start 'Breathing' Activity");
            Console.WriteLine("2. Start 'Reflecting' Activity");
            Console.WriteLine("3. Start 'Listing' Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a number from the menu: ");
        }
    }
}