using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        displayWelcome();

        string userName = getUserName();
        int userNum = getUserNumber();

        int square = squareNum(userNum);

        displayEnd(userName, square);

    }

    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program! I hope you enjoy your stay!");
    }

    static string getUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int getUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNum(int number)
    {
        int square = number * number;
        
        return square;
    }

    static void displayEnd(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}