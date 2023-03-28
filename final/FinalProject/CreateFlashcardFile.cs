using System;
using System.IO;
using System.Diagnostics;


public class CreateFlashcardFile
{

    private string _subject;



    

    

    public void CreateFile()
    {
        //string folderPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string folderPath = Path.Combine(Environment.CurrentDirectory, "FlashcardFiles");

        string filePath = Path.Combine(folderPath, $"{_subject}.txt");

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("DELETE -- Write your flashcards like this \nQuestion | Answer --");
            
        }

        Process.Start(new ProcessStartInfo()
        {
            FileName = filePath,
            UseShellExecute = true
            
        });

    }



    public string GetSubject()
    {
        return _subject;
    }

    public void SetSubject()
    {
        Console.WriteLine("Type the name of the subject of your studyset:");
        string subject = Console.ReadLine();
        _subject = subject;
        
    }



}