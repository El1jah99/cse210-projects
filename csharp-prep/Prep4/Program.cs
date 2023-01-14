using System;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();

       int userInput = -999;
        
        Console.WriteLine("Enter positive integers - Type 0 when finished.");

       while (userInput != 0)
       {
            
            Console.WriteLine("Enter a positive integer");
            
            userInput = int.Parse(Console.ReadLine());


            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

       }


        int total = numbers.Sum();
        

        Console.WriteLine($"The total is {total}");

        float average = ((float)total) / numbers.Count;

        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int number in numbers)

        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is {max}");    

    }
}