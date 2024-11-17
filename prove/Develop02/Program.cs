using System;
using Develop02;

/*
Review the Program Specs
1. What does the program do? Write Entry, Display Entry, Save, Load, Quit
2. What user inputs does it have? Choices 1-5.
3. What output does it produce? .csv file
4. How does the program end? Option 5: Quit.

Determine Classes
1. What are good candidates for classes in this program?
2. What are the primary responsibilities of each class?
What are the behaviors this class will have in order to fulfill its responsibilities?
(In other words, what things should this class do?)

Define Class Attributes
1. What attributes does this class need to fulfill its behaviors?
    (In other words, what member variables should this class store?)
2. What are the data types of these member variables?

Exceeding Requirements:
1. Added confirmation when saving and loading.
2. Added 16 extra prompts to PromptGenerator. (Total of 21 prompts)
*/

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "-1";
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (userChoice != "5")
        {
            DisplayMenu();
            userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                // generate a random prompt
                string randomPrompt = promptGenerator.GeneratePrompt();
                Console.Write("Prompt: ");
                Console.WriteLine(randomPrompt);

                // get user input
                Console.Write("> ");
                string userText = Console.ReadLine();

                // create a new entry
                Entry newUserEntry = new Entry(DateTime.Now.ToShortDateString(), randomPrompt, userText);

                // add the new entry to the journal
                journal.AddNewEntry(newUserEntry);
            }
            else if (userChoice == "2")
            {
                // display all entries
                journal.DisplayAllEntries();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("Confirm save? (Y/N)");
                userChoice = Console.ReadLine();
                if (userChoice == "y" || userChoice == "Y")
                {
                    // save to file
                    Console.WriteLine("Save to what filename?");
                    string userFileName = Console.ReadLine();
                    journal.SaveToFile(userFileName);
                }
                else
                {
                    continue;
                }
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Confirm load? (Y/N)");
                userChoice = Console.ReadLine();
                if (userChoice == "y" || userChoice == "Y")
                {
                    // load from file
                    Console.WriteLine("Load from what filename?");
                    string userFileName = Console.ReadLine();
                    journal.LoadFromFile(userFileName);
                }
                else
                {
                    continue;
                }
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("See you next time!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select an appropriate number.");
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write New Entry"); // prompt then store entry in string.
            Console.WriteLine("2. Display Entries"); // shows all entries: date, prompt, and entry.
            Console.WriteLine("3. Save File"); // save all entries to a csv file.
            Console.WriteLine("4. Load"); // load entries from a csv file.
            Console.WriteLine("5. Quit"); // exit the program.
            Console.Write("Enter the number of your choice: ");
        }
    }
}