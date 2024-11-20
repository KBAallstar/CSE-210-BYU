using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");

        while (userInput != "quit")
        {
            /*
            scripture.ShowAllVisibleWords();
            Console.WriteLine();
            Console.WriteLine();
            */

            Console.Write(reference.GetDisplayText() + " ");
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(2);

                if (scripture.IsCompletelyHidden() == true)
                {
                    Console.Clear();
                    Console.Write(reference.GetDisplayText() + " ");
                    Console.WriteLine(scripture.GetDisplayText());
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}