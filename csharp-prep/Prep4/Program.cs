using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        
        List<int> numbers = new List<int>();
        int input;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.WriteLine("Enter number: ");
            string inputStr = Console.ReadLine();
            input = int.Parse(inputStr);

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }

        double average = (double) sum / numbers.Count;

        int max = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        int positiveMin = 999999999;

        for (int i= 0; i < numbers.Count; i++)
        {
            if (numbers[i] < positiveMin && numbers[i] >= 0)
            {
                positiveMin = numbers[i];
            }
        }

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest postive number is: {positiveMin}");
        Console.WriteLine("The sorted list is:");

        numbers.Sort();

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}