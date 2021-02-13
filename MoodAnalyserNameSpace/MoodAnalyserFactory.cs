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

                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MOOD, "Class Not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MOOD, "Constructor is Not found");
            }

        }
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyserClass);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {

                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NOSUCHMETHOD, "Constructor Not found");
                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NOSUCHCLASS, "Class is Not found");
            }

        }
        public static string InvokeAnalyseMethod(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserNameSpace.MoodAnalyserClass");
                object moodAnalyseObject =MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserNameSpace.MoodAnalyserClass", "MoodAnalyserClass", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object mood = methodInfo.Invoke(moodAnalyseObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NOSUCHMETHOD, "Method is Not found");
            }
        }
    }
}
