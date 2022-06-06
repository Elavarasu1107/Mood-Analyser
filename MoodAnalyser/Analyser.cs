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
            if(this.message.ToLower().Contains("sad"))
            {
                Console.WriteLine("Your are in Sad Mood");
               return "Sad";
            }
            Console.WriteLine("Your are in Happy mood");
            return "Happy";
        }
    }
}
