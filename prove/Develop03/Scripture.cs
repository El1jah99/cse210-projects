using System;
using System.IO;
using System.Collections.Generic;

public class Scripture
{
    private string _reference;

    private string _text;


    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    private Dictionary<string, string> scriptureDictionary = new Dictionary<string, string>();

    public void AddToDictionary()
    {
        scriptureDictionary.Add(_reference, _text);
        //scriptureDictionary.Add("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    }

    public string DisplayWords(string reference)
    {
        Console.WriteLine(reference);
        Console.WriteLine(scriptureDictionary[reference]);
    
        string text = scriptureDictionary[reference];

        
        return text;
    }

}