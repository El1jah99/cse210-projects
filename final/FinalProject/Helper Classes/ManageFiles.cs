using System;


class ManageFiles
{   

    
    public static string ChooseFile(string folder)
    {
        string folderPath = Path.Combine(Environment.CurrentDirectory, folder);

        string[] files = Directory.GetFiles(folderPath);

        Console.WriteLine("Choose a studyset:");
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {Path.GetFileName(files[i])}");
        }

        int choice;
        while (true)
        {
            //Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= files.Length)
            {
                break;
            }
            Console.WriteLine("Invalid input. Try again.");
        }

        return files[choice - 1];
    }


    public static void DeleteFile(string folder)
    {
        string folderPath = Path.Combine(Environment.CurrentDirectory, folder);
        
        string filePath = ChooseFile(folder);

        if (filePath == null)
        {
            // Handle cancellation
            Console.WriteLine("Invalid file path.");
        }
        else
        {
            // Delete the file
            File.Delete(filePath);
            Console.WriteLine($"{Path.GetFileName(filePath)} has been deleted.");
        }
    }



}