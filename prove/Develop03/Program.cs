using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        Reference ref1 = new Reference("Doctrine & Covenants", 13, 1);
        Scripture script1 = new Scripture(ref1, "Upon you my fellow servants, in the name of Messiah I confer the Priesthood of Aaron, which holds the keys of the ministering of angels, and of the gospel of repentance, and of baptism by immersion for the remission of sins; and this shall never be taken again from the earth, until the sons of Levi do offer again an offering unto the Lord in righteousness.");

        Reference ref2 = new Reference("Doctrine & Covenants", 4, 1, 7);
        Scripture script2 = new Scripture(ref2, "Now behold, a marvelous work is about to come forth among the children of men. Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day. Therefore, if ye have desires to serve God ye are called to the work; For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul; And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work. Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence. Ask, and ye shall receive; knock, and it shall be opened unto you. Amen.");

        Reference ref3 = new Reference("1 Nephi", 3, 7);
        Scripture script3 = new Scripture(ref3, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        // Adding in a random function to pick one of the three scriptures to display

        Random random = new();

        // int toDisplay = random.Next(3) + 1;

        int toDisplay = 3;

        // Testing how far the code gets

        // Console.WriteLine($"The script was able to get to stage 1, the random number is {toDisplay}");

        if (toDisplay == 1)
        {
            while(!script1.IsCompletelyHidden())
            {
                int toHide = random.Next(5) + 2;

                Console.Clear();
                Console.WriteLine(script1.GetDisplayText());

                Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                string input = Console.ReadLine();

                // Found a better way to compare two strings while ignoring case sensitivity.

                bool comparison = String.Equals(input, "quit", StringComparison.OrdinalIgnoreCase);

                if (comparison)
                {
                    return;
                }

                script1.HideRandomWords(toHide);
            }

            Console.Clear();
            Console.WriteLine("Contrats! You memorized the scripture.");
        }
        else if (toDisplay == 2)
        {
            while(!script2.IsCompletelyHidden())
            {
                int toHide = random.Next(5) + 2;
                
                Console.Clear();
                Console.WriteLine(script2.GetDisplayText());

                Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                string input = Console.ReadLine();

                // Found a better way to compare two strings while ignoring case sensitivity.

                bool comparison = String.Equals(input, "quit", StringComparison.OrdinalIgnoreCase);

                if (comparison)
                {
                    return;
                }

                script2.HideRandomWords(toHide);
            }

            Console.Clear();
            Console.WriteLine("Contrats! You memorized the scripture.");
        }
        else if (toDisplay == 3)
        {
            while(!script3.IsCompletelyHidden())
            {
                int toHide = random.Next(5) + 2;

                Console.Clear();
                Console.WriteLine(script3.GetDisplayText());

                Console.WriteLine();
                Console.WriteLine($"The number of lines to hide is: {toHide}");

                Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
                string input = Console.ReadLine();

                // Found a better way to compare two strings while ignoring case sensitivity.

                bool comparison = String.Equals(input, "quit", StringComparison.OrdinalIgnoreCase);

                if (comparison)
                {
                    return;
                }

                script3.HideRandomWords(toHide);
            }

            Console.Clear();
            Console.WriteLine("Contrats! You memorized the scripture.");
        }
    }
}