using System;
using System.IO;

// To generate writing prompts, you must add your openai API key to openaiPrompt.py
class Program 
{
    static void Main(string[] args)
    {

        Menu menu1 = new Menu();
        
            menu1._optionOne = "1. Write";
            menu1._optionTwo = "2. Display";
            menu1._optionThree = "3. Import";
            menu1._optionFour = "4. Export";
            menu1._optionFive = "5. Quit";
            menu1._userPrompt = "What would you like to do?"; 
 

        Console.WriteLine("Welcome to your journal!");
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string journalFile = "journalEntries.txt";

        int userInputInt;
        

        do
        {
            menu1.DisplayMenu();
            userInputInt = Convert.ToInt32(Console.ReadLine());

            if (userInputInt == 1)
            {
                Entry entry = new Entry();
                    entry.DisplayPrompt();
                    string prompt = File.ReadAllText("JournalPrompts.txt");
                    Console.WriteLine(prompt);            
                    entry._dateTime = dateText;
                    entry._journalEntry = Console.ReadLine();
                

                    if (entry._journalEntry != "5")
                        entry.SaveFile(prompt);
                
            }

            else if (userInputInt == 2)

            {
                var entries = File.ReadLines(journalFile);

                foreach (string entry in entries)
                {
                    Console.WriteLine(entry);
                }
            }

            else if (userInputInt == 3)

            {
                Console.WriteLine("Input the file you wish to load:");

                string userPastEntriesFile = Console.ReadLine();

                var pastEntries = File.ReadLines(userPastEntriesFile);
                
                using (StreamWriter outputFile = new StreamWriter(journalFile))

                foreach (string line in pastEntries)
                {
                    outputFile.WriteLine(line);
                }

            }

            else if (userInputInt == 4)

            {
                Save newSave = new Save();

                newSave._journalEntries = journalFile;

                Console.WriteLine("Input the file you would like to save to:");
                newSave._newFileName = Console.ReadLine();
                
                newSave.SaveJournaltoFile(journalFile);

            }

            

        } while (userInputInt != 5);


    }
    

}
