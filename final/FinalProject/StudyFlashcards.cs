using System;
using System.IO;

public class StudyFlashcards : StudySession
{
    private Dictionary<string, string> flashcardDictionary = new Dictionary<string, string>();

    public override void StartStudySession()
    {

       StartFlashcards(); 

    }

    private void StartFlashcards()
    {   

        string filePath = ManageFiles.ChooseFile();

        AddToDictionary(filePath);

        string userInput;


        foreach (string key in flashcardDictionary.Keys)
        {
            Console.Clear();
            Console.WriteLine("Press enter to see the answer, or type quit to exit:\n" + key);
            userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            Console.WriteLine(flashcardDictionary[key]);
            userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

        }


    }

    public void AddToDictionary(string fileName)
    {

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {

            string[] parts = line.Split('|');
            flashcardDictionary.Add(parts[0], parts[1]);

        }
        
    }


   public void DisplayQuestion(string question)
    {   

        Console.WriteLine(question);

    }
    public void DisplayAnswer(string question)
    {
        
        Console.WriteLine(flashcardDictionary[question]);
    
    }

    




}