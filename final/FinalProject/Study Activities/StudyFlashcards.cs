using System;
using System.IO;

public class StudyFlashcards : StudySession
{

    private int _numFlashcardsStudied;

    private Dictionary<string, string> flashcardDictionary = new Dictionary<string, string>();

    public override void StartStudySession()
    {

       StartFlashcards(); 

    }

    public override void EndStudySession()
    {
        EndFlashcards();
    }

    private void EndFlashcards()
    {
        Console.Clear();

        Console.WriteLine($"\nYou have completed your study session. You studied {_numFlashcardsStudied} flashcards.\n");

        Console.ReadLine();
    }

    private void StartFlashcards()
    {   

        string filePath = ManageFiles.ChooseFile("FlashcardFiles");

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


            _numFlashcardsStudied += 1;
        }


    }

    private void AddToDictionary(string fileName)
    {

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {

            string[] parts = line.Split('|');
            flashcardDictionary.Add(parts[0], parts[1]);

        }
        
    }




}