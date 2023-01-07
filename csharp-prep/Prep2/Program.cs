using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercent = Console.ReadLine();

        int gradePercentInt = int.Parse(gradePercent);
        
        string letterGrade = "";

        if (gradePercentInt >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentInt >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentInt >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentInt >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is {letterGrade}");

        if (gradePercentInt >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. Try again next semester.");
        }


            }

}