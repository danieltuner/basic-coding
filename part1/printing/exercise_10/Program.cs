using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");
            string message = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string message2 = Console.ReadLine();
            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a " + message2 + " called " + message);
            Console.WriteLine("On her way to work, " + message + " often pondered what being " + message2 + " meant to them.");
            Console.WriteLine("When you work as a " + message2 + " you meet interesting people.");
            Console.WriteLine(message + " enjoys their work as " + message2 + ", The end.");

        }
    }
}
