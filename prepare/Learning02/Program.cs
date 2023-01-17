using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "Pluralsight";
        job1._jobTitle = "Web Developer";
        job1._startYear = 2017;
        job1._endYear = 2023;

        Job job2 = new Job();

        job2._company = "Google";
        job2._jobTitle = "Advertisement Specialist";
        job2._startYear = 2012;
        job2._endYear = 2017;

        Console.WriteLine($"{job1._company}");
        Console.WriteLine($"{job2._company}");

        job1.Display();

        Resume myResume = new Resume();

        myResume._name = "Benjamin Dowdle";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}