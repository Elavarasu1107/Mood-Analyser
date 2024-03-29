﻿using System;
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
            Match result = Regex.Match(pattern, className);

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
        public static object MoodAnalyserUsingParamaterisedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(Analyser);
            if(type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] {typeof (string)});
                    object instance = constructor.Invoke(new[] {message});
                    return instance;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
        public static string InvokeMoodAnalyser(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser.Analyser");
                object moodAnalyserObject = MoodAnalyserUsingParamaterisedConstructor("MoodAnalyser.Analyser", "Analyser", message);
                MethodInfo analyseMethodInfo = type.GetMethod(methodName);
                object mood = analyseMethodInfo.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Method Not Found");
            }
        }
        public static string DynamicMood(string message, string fieldName)
        {
            try
            {
                MoodAnalyser.Analyser moodAnalyse = new Analyser();
                Type type = typeof(Analyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (message == null)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_FIELD, "Message should not be null");
                }
                field.SetValue(moodAnalyse, message);
                return moodAnalyse.message;
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_FIELD, "Field Not Found");
            }
        }
    }
}
