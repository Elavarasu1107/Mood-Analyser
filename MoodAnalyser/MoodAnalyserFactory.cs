using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object MoodObject(string className, string constructorName)
        {
            string pattern = @"^"+constructorName+"$";
            Match result = Regex.Match(className, pattern);

            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type analyserType = executing.GetType(className);
                    return Activator.CreateInstance(analyserType);
                }
                catch(ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Class Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
            }
        }
    }
}
