using System;
using System.IO;
using System.Collections.Generic;

public class Flashcard
{
    private string _question;

    private string _answer;

    private string _fileName;






 

    public string GetQuestion()
    {
        return _question;
    }

    public void SetQuestion(string question)
    {
        _question = question;
    }

    public string GetText()
    {
        return _answer;
    }

    public void SetText(string text)
    {
        _answer = text;
    }

    // public Dictionary<string, string> GetDictionary()
    // {
    //     return flashcardDictionary;
    // }
}