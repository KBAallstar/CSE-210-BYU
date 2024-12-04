using System;

namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAssignment mathAssignment = new MathAssignment("Britney Spears", "Math", "Chapter 1", "1-10");
            WritingAssignment writingAssignment = new WritingAssignment("Christina Aguilara", "Writing", "The Great American Novel");

            Console.WriteLine(mathAssignment.GetHomeworkList());
            Console.WriteLine(writingAssignment.GetWritingInformation());
        }
    }
}