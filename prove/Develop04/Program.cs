using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        string input = "";

        // Added a count with a display of the number of times that each activity has been completed in the current session
        int breathCount = 0;
        int reflectCount = 0;
        int listCount = 0;
        int duration = 0;

        void DisplayLog()
        {
            // Added the date format with showing the date in specialized format
            DateTime todaysDate = DateTime.Today;
            string thisDay = todaysDate.ToString("D");
            Console.WriteLine($"Activity Log | Current Session | {thisDay}");
            Console.WriteLine($"Breathing Activity: {breathCount}");
            Console.WriteLine($"Reflecting Activity: {reflectCount}");
            Console.WriteLine($"Listing Activity: {listCount}");
            Console.WriteLine();
        }

        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("Welcome to the mindfulness app, please take some time to relax and become more mindful.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start a breathing activity");
            Console.WriteLine("2. Start a reflecting activity");
            Console.WriteLine("3. Start a listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();

            if (input != "4")
            {
                Console.WriteLine();
                Console.Write("How long would you like to do this activity? (in seconds) ");
                string tempDuration = Console.ReadLine();
                duration = Int32.Parse(tempDuration);
            }

            switch (input) // Researched how to use the switch function instead of using while or if statements
            {
                case "1":
                    Breathing breth = new Breathing(duration);
                    breth.Run();

                    breathCount++;
                    break;

                case "2":
                    Reflecting reflect = new Reflecting(duration);
                    reflect.Run();

                    reflectCount++;
                    break;

                case "3":
                    Listing list = new Listing(duration);
                    list.Run();

                    listCount++;
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid selection, please enter a valid option.\n");
                    break;
            }
        }
    }
}