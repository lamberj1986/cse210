using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");

        // DateTime startTime = DateTime.Now;
        // DateTime stopTime = startTime.AddSeconds(seconds);
        // DateTime currentTime = DateTime.Now;

        // int freezeTime = 500; // Adding this to be able to update the animation time without having to change multple lines

        // while (currentTime < stopTime)
        // {
        //     Console.Write("-");
        //     Thread.Sleep(freezeTime);

        //     Console.Write("\b \b");
        //     Console.Write("\\");

        //     Thread.Sleep(freezeTime);

        //     Console.Write("\b \b");
        //     Console.Write("-");

        //     Thread.Sleep(freezeTime);

        //     Console.Write("\b \b");
        //     Console.Write("/");

        //     Thread.Sleep(freezeTime);

        //     Console.Write("\b \b");
        //     Console.Write("-");

        //     Thread.Sleep(freezeTime);

        //     currentTime = DateTime.Now;
        // }

        // int spinnerPosition = 25;
        // int spinWait = 500;

        // spinnerPosition = Console.CursorLeft;

        // DateTime startTime = DateTime.Now;
        // DateTime futureTime = startTime.AddSeconds(5);

        // while(DateTime.Now < futureTime)
        // {
        //     char[] spinChars = new char[]{'|','/','-','\\'};
        //     foreach (char spinChar in spinChars)
        //     {
        //         Console.CursorLeft = spinnerPosition;
        //         Console.Write(spinChar);
        //         Thread.Sleep(spinWait);
        //     }
        // }
        // Console.CursorLeft = spinnerPosition;
        // Console.Write(" ");

        string userName = "<Type your name here>";
        string dateString = DateTime.Today.ToShortDateString();

        // Use the + and += operators for one-time concatenations.
        string str = "Hello " + userName + ". Today is " + dateString + ".";
        System.Console.WriteLine(str);

        str += " How are you today?";
        System.Console.WriteLine(str);
    }
}