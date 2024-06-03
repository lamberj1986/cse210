using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        // General address to be used by all events
        Address address = new Address("123 Main Street", "Provo", "Utah", "USA");

        // Creating each event to then be displayed later on
        Lecture lecture = new Lecture("How to get an A in CSE 210", "Learning all of the tips and tricks to navigating the world of C#", "June 3rd, 2024", "7:00 PM", address, "John Q. Public", 250);
        Reception reception = new Reception("Michael & Annette's 60th Anniversary", "Come celebrate 60 years of marriage for Michael and Annette. Gifts are welcome, but not necessary", "June 17th, 2024", "6:30 PM", address, "60HappyYears@email.com");
        OutdoorGathering outdoor = new OutdoorGathering("Our Ward Picnic", "Our annual ward picnic to be held in the park. Please bring a side dish to share.", "June 24th, 2024", "11:30 AM", address, "Sunny and in the 80s");

        // Displaying the details for each event
        Console.WriteLine("Event 1: Lecture");
        Console.WriteLine("Standard: \n" + lecture.GetStandardDetails());
        Console.WriteLine("Full: \n" + lecture.GetFullDetails());
        Console.WriteLine("Short: \n" + lecture.GetShortDescription());

        Console.WriteLine("Event 2: Reception");
        Console.WriteLine("Standard: \n" + reception.GetStandardDetails());
        Console.WriteLine("Full: \n" + reception.GetFullDetails());
        Console.WriteLine("Short: \n" + reception.GetShortDescription());

        Console.WriteLine("Event 3: Outdoor");
        Console.WriteLine("Standard: \n" + outdoor.GetStandardDetails());
        Console.WriteLine("Full: \n" + outdoor.GetFullDetails());
        Console.WriteLine("Short: \n" + outdoor.GetShortDescription());
    }
}