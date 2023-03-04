using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
    

        do
        {
                    
            Scripture scripture = new Scripture();

            //Console.WriteLine("Input the reference of the scripture you would like to study (e.g. John 3:16):");
            //string reference = Console.ReadLine();

            //Console.WriteLine($"Input the text of {reference}:");
            //string text = Console.ReadLine();

            string reference = "John 3:16-17";
            string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. \nFor God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
    

            scripture.SetReference(reference);
            scripture.SetText(text);

            scripture.AddToDictionary();

            scripture.DisplayWords(reference);

            Words words = new Words();

            words.SetReference(reference);
            words.SetText(text);
           

            userInput = words.HideWords();
            

        } 
        while (userInput != "quit");

    }


}