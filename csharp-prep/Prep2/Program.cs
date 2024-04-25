using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        
        Console.WriteLine("What is the grade percentage? ");
        string gradeString = Console.ReadLine();

        int grade = int.Parse(gradeString);
        string letterGrade;

        if (grade >= 90)
        {
            // Console.WriteLine("Your grade is an A");
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            // Console.WriteLine("Your grade is a B");
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            // Console.WriteLine("Your grade is a C");
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            // Console.WriteLine("Your grade is a D");
            letterGrade = "D";
        }
        else
        {
           // Console.WriteLine("Your grade is an F");
           letterGrade = "F";
        }

        int onesDigit = grade % 10;
        string newLetterGrade = letterGrade;

        if (onesDigit >=7)
        {
            if (letterGrade == "B" || letterGrade == "C"  || letterGrade == "D")
            {
                newLetterGrade = letterGrade + "+";
            }
            else
            {
                newLetterGrade = letterGrade;
            }
        }
        else if (onesDigit <= 3 && letterGrade != "F")
        {
            newLetterGrade = letterGrade + "-";
        }
        else
        {
            newLetterGrade = letterGrade;
        }

        Console.WriteLine($"Your grade in this class is: {newLetterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sadly, you did not pass the class.");
        }
    }
}