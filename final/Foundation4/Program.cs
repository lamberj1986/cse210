using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");

        Running run = new Running("June 6th, 2024", 30, 2.5);
        StationaryBike bike = new StationaryBike("June 7th, 2024", 45, 15);
        Swimming swim = new Swimming("June 9th, 2024", 60, 300);

        Console.WriteLine("Exercise activites for June:");
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(bike.GetSummary());
        Console.WriteLine(swim.GetSummary());
    }
}