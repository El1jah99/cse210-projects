using System;


public class TakeQuiz : StudySession
{
    private string _fileName;


    public void SetFileName()
    {
       _fileName = ManageFiles.ChooseFile("QuizFiles");
    }
    public override void StartStudySession()
    {
        SetFileName();
        StartQuiz(); 

    }

    public override void EndStudySession()
    {
        EndQuiz();
    }

    private void StartQuiz()
    {
    
        Dictionary<string, List<string>> questions = new Dictionary<string, List<string>>();
        Dictionary<int, int> answerkey = new Dictionary<int, int>();

        string[] lines = File.ReadAllLines(_fileName);

        int questionNum = 1; 

        foreach (string line in lines)
        {
            

            string[] parts = line.Split('|');
            string question = parts[0];

            List<string> choices = new List<string> {parts[1], parts[2], parts[3], parts[4]};
            int answer = int.Parse(parts[5]);

            int correctIndex = int.Parse(parts[5]);

            questions.Add(question, choices);
            answerkey.Add(questionNum, answer); 

            questionNum++;
        }

        // Initialize variables
        int totalQuestions = questions.Count;
        int totalCorrect = 0;
        List<string> report = new List<string>();

        // Loop through each question
        int questionNumber = 1;

        foreach (string question in questions.Keys)
        {
            Console.Clear();

            Console.WriteLine($"Question {questionNumber}/{totalQuestions}: {question}");

            List<string> choices = questions[question];


            for (int i = 0; i < choices.Count; i++)
            {

                Console.WriteLine($"{i + 1}. {choices[i]}");

            }

            Console.Write("Enter your answer (1-4): ");

            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer == answerkey[questionNumber])
            {

                Console.WriteLine("Correct!");
                totalCorrect++;
                report.Add($"Question {questionNumber}: correct");

            }

            else
            {

                Console.WriteLine("Incorrect.");
                report.Add($"Question {questionNumber}: incorrect");

            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            questionNumber++;
        }

        // Print report
        Console.Clear();
        Console.WriteLine("Quiz report:");

        foreach (string line in report)
        {

            Console.WriteLine(line);

        }

        Console.WriteLine($"Score: {totalCorrect}/{totalQuestions}");
        Console.ReadLine();

    }


    private void EndQuiz()
    {
        Console.Clear();
        Console.WriteLine($"Nice Work!\nPress enter to return to the main menu.");
        Console.ReadLine();
    }

}