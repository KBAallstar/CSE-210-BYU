using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int gradePercentage = int.Parse(answer);

        string gradeLetter = "";

        if (gradePercentage >= 90) {
            gradeLetter = "A";
        } else if (gradePercentage >= 80) {
            gradeLetter = "B";
        } else if (gradePercentage >= 70) {
            gradeLetter = "C";
        } else if (gradePercentage >= 60) {
            gradeLetter = "D";
        } else {
            gradeLetter = "F";
        }

        if ((gradePercentage < 95) && (gradePercentage % 10 >= 7)) {
            gradeLetter += "+";
        } else if ((gradePercentage < 95) && (gradePercentage % 10 <= 3)) {
            gradeLetter += "-";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");
        
        if (gradePercentage >= 70) {
            Console.WriteLine("You passed the class!");
        } else {
            Console.WriteLine("You failed the class. Please sign up for a retake.");
        }
    }
}