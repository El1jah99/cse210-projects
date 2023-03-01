using System;
using System.Linq;

public class Words
{

    private string _text;
    
    private string _reference;


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
        return _reference;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    

    public string HideWords()
    {
        string[] words = _text.Split(' ');
        
        bool[] hiddenWords = new bool[words.Length];

        int counter = 0;

        while (true)
        {
            

            Console.WriteLine("\nPress enter to hide a new word or type quit to exit:");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                return userInput;
            }
            

            int wordIndex = GetRandomHiddenWordIndex(hiddenWords);
            hiddenWords[wordIndex] = true;
            words[wordIndex] = new string('_', words[wordIndex].Length);

            string output = string.Join(' ', words);

            Console.Clear();

            Console.WriteLine(output);

            counter ++;

           
            if(counter >= words.Length)
            {
                Console.Clear();
                return "quit";
                
            }
        }
    }

    private int GetRandomHiddenWordIndex(bool[] hiddenWords)
    {
        Random random = new Random();
        int index;

        do
        {
            index = random.Next(hiddenWords.Length);

        } while (hiddenWords[index]);

        return index;
    }
}