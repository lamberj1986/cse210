using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        // Video 1, with comments, came from here: https://www.youtube.com/watch?v=rhvF2_JkDhQ
        // Video #1
        Video vidOne = new Video("Life could be a dream", "Desmait",29);

        // Comment #1
        Comment newComOne = new Comment("grimblob7305", "The way the guy falls in, he just accepst his fate.");
        vidOne.AddComment(newComOne);
        
        // Comment #2
        Comment newComTwo = new Comment("michaeldarick7192", "The fact that he didn't panic at all when he knew he was going under is impressive.");
        vidOne.AddComment(newComTwo);

        // Comment #3
        Comment newComThree = new Comment("mariacaskinha", "If a movie started like this I would be the happiest person in the world");
        vidOne.AddComment(newComThree);

        // Comment #4
        Comment newComFour = new Comment("scupking", "This is one of the best videos on YouTube!!!");
        vidOne.AddComment(newComFour);

        // Video 2, with comments, came from here: https://www.youtube.com/watch?v=spMkaJp975s
        // Video #2
        Video vidTwo = new Video("It's Casper", "Monkey react to magic", 222);

        // Comment #1
        newComOne = new Comment("shi117", "The fact that these monkeys understand what's happening is abnormal and get surprised by it shows how smart they are.");
        vidTwo.AddComment(newComOne);

        // Comment #2
        newComTwo = new Comment("spade3779", "The Organutan looks like some kind of old wizard with his magic stick lol.");
        vidTwo.AddComment(newComTwo);

        // Comment #3
        newComThree = new Comment("idkmyusername1677", "Man: Pushes card through window\n\n                        Orangutan: Impressive I admit, but it's still no match for my ancient orangutan technique.");
        vidTwo.AddComment(newComThree);

        // Comment #4
        newComFour = new Comment("alinayang1201", "The way the monkey hugged the guy at the end was so cute");
        vidTwo.AddComment(newComFour);

        // Video 3, with comments, came from here: https://www.youtube.com/watch?v=v-nGdg1K36A
        // Video #3
        Video vidThree = new Video("Stephen Patula", "McDonalds POV: Big Mac", 120);

        // Comment #1
        newComOne = new Comment("advang4820", "To this day, I'm still hoping to get a Big Mac that looks exactly like from printed ad, commercial or food showcase at least once in my life.");
        vidThree.AddComment(newComOne);

        // Comment #2
        newComTwo = new Comment("user-sn9xo4uc9z", "I can't stop watching this! So enertaining!");
        vidThree.AddComment(newComTwo);

        // Comment #3
        newComThree = new Comment("BrentLA", "Every time I eat McDonald's now I think of your videos");
        vidThree.AddComment(newComThree);

        // Comment #4
        newComFour = new Comment("TheKurtsPlaceChannel", "Very nicely put together video and very entertaining as well. Thanks for posting this.");
        vidThree.AddComment(newComFour);

        // Video 4, with comments, came from here: https://www.youtube.com/watch?v=cdmKVXynX3I
        // Video #4
        Video vidFour = new Video("FailArmy", "Best Sports Fails | Dumb Athletes", 1371);

        // Comment #1
        newComOne = new Comment("UniDisforlife", "00:42 had me LAUGHING!!!\n");
        vidFour.AddComment(newComOne);

        // Comment #2
        newComTwo = new Comment("brmenna", "That's the video with the most flinch scares ever, I think I've flinched 20 times lmao");
        vidFour.AddComment(newComTwo);

        // Comment #3
        newComThree = new Comment("AnthonyD1986", "THIS is why aliens won't visit us.");
        vidFour.AddComment(newComThree);

        // Comment #4
        newComFour = new Comment("Kragatar", "8:13 The most intense hockey fight of all time.");
        vidFour.AddComment(newComFour);

        // Displaying out all of the information for video 1
        Console.WriteLine("Details for video 1:");
        vidOne.DisplayInfo();

        // Displaying out all of the information for video 2
        Console.WriteLine("\n\nDetails for video 2:");
        vidTwo.DisplayInfo();

        // Displaying out all of the information for video 3
        Console.WriteLine("\n\nDetails for video 3:");
        vidThree.DisplayInfo();

        // Displaying out all of the information for video 4
        Console.WriteLine("\n\nDetails for video 4:");
        vidFour.DisplayInfo();
    }
}