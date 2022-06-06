using System;

namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Mood:");
            string userInput = Console.ReadLine();
            Analyser getMethod = new Analyser(userInput);
            getMethod.Mood();
        }
    }
}
