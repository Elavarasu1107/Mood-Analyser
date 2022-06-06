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
                if(this.message.Contains(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.ENTERED_EMPTY, "Message should not be Empty");
                    
                }
                if (this.message.ToLower().Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.ENTERED_NULL, "Message should not be Null");
            }
        }
    }
}