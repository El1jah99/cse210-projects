using System;


public class Save // Exports journal to a new file
{
    public string _newFileName;

    public string _journalEntries;


    public void SaveJournaltoFile(string journalEntries)
    {
        var journalEntriesLines = File.ReadLines(journalEntries);

        using (StreamWriter outputFile = new StreamWriter(_newFileName,true))
        
        foreach (string line in journalEntriesLines)
        {
            outputFile.WriteLine(line);
        }
    }
}
