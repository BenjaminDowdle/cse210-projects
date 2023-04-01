using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Exercise Tracker");
        Console.WriteLine();

        List<Activity> activityList = new List<Activity>{
            new Running(45, 5),
            new Cycling(60, 15),
            new Swimming(40, 22)
        };

        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}