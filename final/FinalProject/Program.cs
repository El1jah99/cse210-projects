using System;

public class Program
{
    static void Main(string[] args)
    {
        
        Dictionary<string, Command> commands = new Dictionary<string, Command>();

        commands["1"] = new StudyFlashcardsCommand();
        commands["2"] = new CreateFlashcardsCommand();
        commands["3"] = new DeleteFlashcardsCommand();

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

                    if (userInputInt > 3)
                    {
                        Environment.Exit(0);
                    }

                    Console.Clear();

                    commands[userInput].Execute();

                
                }while(userInputInt < 4);

            }

            catch (Exception)
                {
                    Environment.Exit(0);
                }




    }
}