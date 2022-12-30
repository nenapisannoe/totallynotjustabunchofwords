using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] lines = { "Oh, hey, you're back.", "Hyperion would like to remind you that there is only one thing worse than respawning, and that is not respawning.", "The Hyperion corporation suggests: Live! LIIIIIIIIVVVVVVVVE!", "The Hyperion corporation is sure none of that was your fault.",
                                "Oh, it's you again.", "The Hyperion Corporation: We make your life. Period."};
            Console.WriteLine(lines[rnd.Next(lines.Length())]);
        }
    }
}
