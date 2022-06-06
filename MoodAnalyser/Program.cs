using System;

namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userInput = null;
            Analyser getMethod = new Analyser(userInput);
            getMethod.Mood();
        }
    }
}
