using System;

public class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, Command> commands = new Dictionary<string, Command>();

        commands["1"] = new StudyFlashcardsCommand();
        commands["2"] = new TakeQuizCommand();
        commands["3"] = new CreateFlashcardsCommand();
        commands["4"] = new CreateQuizCommand();
        commands["5"] = new DeleteFlashcardsCommand();
        commands["6"] = new DeleteQuizzesCommand();

        string userInput;
        int userInputInt;


        try
        {

            do
            {

                Menu menu = new Menu();
                menu.DisplayMenu();

                userInput = Console.ReadLine();

                userInputInt = Convert.ToInt32(userInput);

                if (userInputInt > 6)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }

                Console.Clear();

                commands[userInput].Execute();


            } while (userInputInt < 7);

        }

        catch (Exception)
        {
            Console.Clear();
            Environment.Exit(0);
        }




    }
}