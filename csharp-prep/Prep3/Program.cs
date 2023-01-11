using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,100);



        int guess = -1;
        int guessCount = 1;

        while (guess != randomNumber)
        {   
            Console.WriteLine("Take a guess at the number I'm thinking of: ");
            guess = int.Parse(Console.ReadLine());
            
            
            guessCount += 1;
        
            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");
                
                
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Nailed it!");
                Console.WriteLine($"It took you {guessCount} guesses");
            }

        
        }
    }
}