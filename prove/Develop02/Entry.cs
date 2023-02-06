using System;
using System.IO;
using System.Diagnostics;

public class Entry
{
    
    public string _dateTime;

    public string _journalEntry; 

    public void DisplayPrompt() //Runs openaiPrompt.py to get a prompt from GPT-3. You may need to update the path
    {
        var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        Process p = new Process();

            p.StartInfo = new ProcessStartInfo(userProfile + "/AppData/Local/Programs/Python/Python310/python.exe", "openaiPrompt.py");
            p.Start();
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.Start();
            string output = p.StandardOutput.ReadToEnd();
            string error = p.StandardError.ReadToEnd();
            p.WaitForExit();
        
    }

    public void SaveFile(string prompt) 
    {
        string fileName = "journalEntries.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            
            outputFile.WriteLine();
            outputFile.WriteLine(_dateTime);
            outputFile.WriteLine(prompt);
            outputFile.WriteLine();
            outputFile.WriteLine(_journalEntry);

        }

    }
}
