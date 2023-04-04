using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment a1 = new Assignment("Elijah Miller", "Computer Science");
        Console.WriteLine(a1.GetSummary());

        
        MathAssignment a2 = new MathAssignment("Elijah Miller", "Fractions", "8.2", "5-28");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Elijah Miller", "American History", "The Great Depression");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());



    }
}