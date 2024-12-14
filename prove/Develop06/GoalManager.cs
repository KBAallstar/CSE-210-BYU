using System;
using System.IO;

namespace Develop06
{
    public class GoalManager
    {
        List<Goal> _goals;
        int _score = 0;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {

        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Player score: {_score}.");
        }

        public void ListGoalNames()
        {
            Console.WriteLine("~~~ CURRENT GOALS ~~~");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to display.");
                Console.WriteLine("Press ENTER to return to menu.");
                Console.ReadLine();
                return;
            }
            else
            {
                for (int i = 0; i < _goals.Count; i++)
                {
                    string completionBox = "[ ]";
                    if (_goals[i].IsComplete() == true)
                    {
                        completionBox = "[X]";
                    }
                    Console.WriteLine($"{i + 1}. {completionBox} {_goals[i].GetShortName()}");
                }
            }
        }

        public void ListGoalDetails()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to display.");
                Console.WriteLine("Press ENTER to return to menu.");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("~~~ CURRENT GOALS ~~~");
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                }
                Console.WriteLine("Press ENTER to return to menu.");
                Console.ReadLine();
            }
        }

        public void DisplayNewGoalMenu()
        {
            // Submenu for selecting Goal type in new Goal creation.
            string userChoice = "-1";
            while (userChoice != "4")
            {
                Console.Clear();
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.WriteLine("   4. Return to previous menu");
                Console.Write("Type a number to select a Goal type: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    CreateGoal("1");
                    break;
                }
                else if (userChoice == "2")
                {
                    CreateGoal("2");
                    break;
                }
                else if (userChoice == "3")
                {
                    CreateGoal("3");
                    break;
                }
                else if (userChoice == "4")
                {
                    Console.WriteLine("~~~ RETURN TO PREVIOUS MENU ~~~");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select an appropriate number.");
                }
            }
        }

        public void CreateGoal(string goalType)
        {
            Console.Clear();
            if (goalType == "1")
            {
                Console.WriteLine("~~~ CREATING A SIMPLE GOAL ~~~");
            }
            else if (goalType == "2")
            {
                Console.WriteLine("~~~ CREATING AN ETERNAL GOAL ~~~");
            }
            else if (goalType == "3")
            {
                Console.WriteLine("~~~ CREATING A CHECKLIST GOAL ~~~");
            }

            Console.Write("Enter the name for the goal: ");
            string name = Console.ReadLine();
            Console.Write("Enter the description of the goal: ");
            string description = Console.ReadLine();
            Console.Write("Enter the points for the goal: ");
            int points = int.Parse(Console.ReadLine());

            if (goalType == "1")
            {
                Goal newGoal = new SimpleGoal(name, description, points);
                _goals.Add(newGoal);
                Console.WriteLine("Simple Goal created successfully.");
                Console.WriteLine("Press ENTER to return to main menu.");
                Console.ReadLine();
            }
            else if (goalType == "2")
            {
                Goal newGoal = new EternalGoal(name, description, points);
                _goals.Add(newGoal);
                Console.WriteLine("Eternal Goal created successfully.");
                Console.WriteLine("Press ENTER to return to main menu.");
                Console.ReadLine();
            }
            else if (goalType == "3")
            {
                Console.Write("Enter number of times you need to complete this goal to get a bonus: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter number of bonus points do you get for completing the goal: ");
                int bonus = int.Parse(Console.ReadLine());

                Goal newGoal = new ChecklistGoal(name, description, points, 0, target, bonus);
                _goals.Add(newGoal);
                Console.WriteLine("Checklist Goal created successfully.");
                Console.WriteLine("Press ENTER to return to main menu.");
                Console.ReadLine();
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("~~~ RECORDING GOAL COMPLETION ~~~");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record events for.");
                Console.WriteLine("Press ENTER to return to main menu.");
                Console.ReadLine();
                return;
            }
            else
            {
                ListGoalNames();
                if (_goals.Count == 0)
                {
                    return;
                }
                else
                {
                    Console.Write("Enter the number you want to record as completed or '0' to return to main menu: ");
                    int goalNumber = int.Parse(Console.ReadLine());
                    if (goalNumber == 0)
                    {
                        return;
                    }
                    else if (goalNumber < 1 || goalNumber > _goals.Count)
                    {
                        Console.WriteLine("Invalid choice. Please select an appropriate number.");
                        return;
                    }
                    else
                    {
                        if (_goals[goalNumber - 1].IsComplete() == true)
                        {
                            Console.WriteLine("Goal already completed.");
                            Console.WriteLine("Press ENTER to return to main menu.");
                            Console.ReadLine();
                            return;
                        }
                        else
                        {
                            _goals[goalNumber - 1].RecordEvent();
                            _score += _goals[goalNumber - 1].GetPoints();
                            Console.WriteLine("Press ENTER to return to main menu.");
                            Console.ReadLine();
                        }
                    }
                }
            }

        }

        public void SaveGoals()
        {
            Console.WriteLine("~~~ SAVING GOALS TO FILE ~~~");
            string filename = "goals.txt";
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"Score//{_score}");
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }

        public void LoadGoals()
        {
            Console.WriteLine("~~~ LOADING GOALS FROM FILE ~~~");
            // check if file exists before loading it
            if (!File.Exists("goals.txt"))
            {
                Console.WriteLine("No save file found.");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
                return;
            }

            PurgeData();

            string filename = "goals.txt";
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("//");
                //string type = parts[0];
                //bool isComplete = bool.Parse(parts[1]);
                //string name = parts[2;
                //string description = parts[3];
                //int points = int.Parse(parts[4]);
                //int amountCompleted = int.Parse(parts[5]);
                //int target = int.Parse(parts[6]);
                //int bonus = int.Parse(parts[7]);

                if (parts[0] == "Score")
                {
                    _score = int.Parse(parts[1]);
                }
                else if (parts[0] == "Simple")
                {
                    Goal newGoal = new SimpleGoal(parts[2], parts[3], int.Parse(parts[4]));
                    newGoal.SetIsComplete(bool.Parse(parts[1]));
                    _goals.Add(newGoal);
                }
                else if (parts[0] == "Eternal")
                {
                    Goal newGoal = new EternalGoal(parts[2], parts[3], int.Parse(parts[4]));
                    newGoal.SetIsComplete(bool.Parse(parts[1]));
                    _goals.Add(newGoal);
                }
                else if (parts[0] == "Checklist")
                {
                    Goal newGoal = new ChecklistGoal(parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    newGoal.SetIsComplete(bool.Parse(parts[1]));
                    _goals.Add(newGoal);
                }
                else
                {
                    Console.WriteLine("Unknown goal type in save file.");
                }
            }

            Console.WriteLine("Goals loaded successfully.");
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
        }

        public void PurgeData()
        {
            _goals.Clear();
            _score = 0;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}