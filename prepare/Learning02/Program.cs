using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2030;

        Job job2 = new Job();
        job2._jobTitle = "Windows AI Software Engineer";
        job2._company = "Nvidia";
        job2._startYear = 2024;
        job2._endYear = 2026;

        Resume resume1 = new Resume();
        resume1._name = "Brayden";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}