using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2017;
        job1._endYear = 2020;
        

        Job job2 = new Job();

        job2._jobTitle = "Systems Engineer";
        job2._company = "NVIDIA";
        job2._startYear = 2020;
        job2._endYear = 2022;
        

        Resume resume = new Resume();

        resume._name = "Elijah M";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);


        resume.DisplayJobs();





        

        


    }
}