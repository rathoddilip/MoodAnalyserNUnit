using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;


namespace MoodAnalyserNameSpace
{
    /// <summary>
    /// Create MoodAnalyseMethod to create object of MoodAnalyse Class.
    /// </summary>
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {

                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.CLASS_NOT_FOUND, "Class Not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor is Not found");
            }

        }
    }
}
