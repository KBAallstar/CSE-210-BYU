using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        // EXCEEDING REQS: get random scripture from library
        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference, reference.GetVerseText());

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

            // check if the scripture is completely hidden
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