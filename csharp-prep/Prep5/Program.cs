using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int userNumberSquared = SquareNumber(userNumber);

        DisplayResult(userName,userNumberSquared);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");

        string name = Console.ReadLine();

        return name;

    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int number = int.Parse(Console.ReadLine());

        return number;


    }

    static int SquareNumber(int userNumber)
    {
        int sqNum = userNumber * userNumber;

        return sqNum;

    }

    static void DisplayResult(string userName, int userNumberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {userNumberSquared}");
    }


}

