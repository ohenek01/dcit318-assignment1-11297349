using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your score (0-100):");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int score) && score >= 0 && score <= 100)
        {
            string grade = CalculateGrade(score);
            Console.WriteLine($"Your grade is: {grade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
    static string CalculateGrade(int score)
    {
        if (score >= 80)
            return "A";
        else if (score >= 75)
            return "B+";
        else if (score >= 70)
            return "B";
        else if (score >= 65)
            return "C+";
        else if (score >= 60)
            return "C";
        else if (score >= 55)
            return "D+";
        else if (score >= 50)
            return "D";
        else if (score >= 45)
            return "E";
        else
            return "F";
    }
}
// This code is a simple console application that calculates a grade based on a score input by the user.