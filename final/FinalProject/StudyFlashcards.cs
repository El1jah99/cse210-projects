using System;

public class StudyFlashcards : StudySession
{

    public override void StartStudySession()
    {

       StartFlashcards(); 

    }

    private void StartFlashcards()
    {

        

    }


   public void DisplayQuestion(string question)
    {   

        Console.WriteLine(question);

    }

    public void DisplayAnswer(string question)
    {
        
        //Console.WriteLine(flashcardDictionary[question]);
    
    }





}