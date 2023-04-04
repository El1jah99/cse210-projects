using System;
using System.IO;
using System.Diagnostics;


public class CreateFiles
{

    private string _subject;

    private string _instructions;

    private string _type;

    private string _folder;


    public void CreateFile()
    {

        string folderPath = Path.Combine(Environment.CurrentDirectory, _folder);

        string filePath = Path.Combine(folderPath, $"{_subject}.txt");

        try
        {

            Process.Start(new ProcessStartInfo()
            {
                FileName = filePath,
                UseShellExecute = true

            });
        }

        catch
        {


            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(_instructions);

            }

            Process.Start(new ProcessStartInfo()
            {
                FileName = filePath,
                UseShellExecute = true

            });

        }

    }


    public string GetSubject()
    {
        return _subject;
    }

    public void SetSubject()
    {
        Console.WriteLine($"Type the name of the subject of your {_type}:");
        string subject = Console.ReadLine();
        _subject = subject;

    }

    public string GetInstructions()
    {
        return _instructions;
    }

    public void SetInstructions(string instructions)
    {
        _instructions = instructions;
    }

    public string GetSetType()
    {
        return _type;
    }

    public void SetSetType(string type)
    {
        _type = type;
    }

    public string GetFolder()
    {
        return _folder;
    }

    public void SetFolder(string folder)
    {
        _folder = folder;
    }
}