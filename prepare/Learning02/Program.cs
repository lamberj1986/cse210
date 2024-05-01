using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2014;
        job1._endYear = 2018;        

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Team Lead";
        job2._startYear = 2020;
        job2._endYear = 2024;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // Console.WriteLine();

        // job1.GetDisplay();
        // job2.GetDisplay();

        // Console.WriteLine();

        Resume theResume = new Resume();

        theResume._name = "Jeff Lambert";

        theResume._jobs.Add(job1);
        theResume._jobs.Add(job2);

        theResume.GetDisplay();

    }
}