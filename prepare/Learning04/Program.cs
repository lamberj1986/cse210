using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment a1 = new Assignment("James Wentz", "Differntial Equations");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Daniel Wallace", "Matricies", "9.4", "9-15");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Joan Rivers", "US History", "D-Day and its impact on the European Front");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}