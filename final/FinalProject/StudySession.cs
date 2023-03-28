using System;


public class StudySession
{
    public StudySession()
    {

    }

    public virtual void StartStudySession()
    {

    }

    public void EndStudySession()
    {
        Console.Clear();

        Console.WriteLine("You have completed your study session.");

    }

    private Dictionary<string, string> flashcardDictionary = new Dictionary<string, string>();

    public void AddToDictionary(string fileName)
    {

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {

            string[] parts = line.Split('|');
            flashcardDictionary.Add(parts[0], parts[1]);

        }
        
    }

}

    
    
    
    
 