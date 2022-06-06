using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser
    {
        public string message;
        public Analyser(string message)
        {
            this.message = message;
        }
        public string Mood()
        {
            try
            {
                if (this.message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                Console.WriteLine("Catch block is Executing");
                return "Happy";
            }
        }
    }
}