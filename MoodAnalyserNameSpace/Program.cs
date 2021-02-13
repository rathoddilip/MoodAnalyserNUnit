using System;

namespace MoodAnalyserNameSpace
{
    public class Program
    { 
        public static void CustomerClassReflections()
        {
            Type type = Type.GetType("MoodAnalyserNameSpace.Customer");

            Console.WriteLine("Full Name is :" + type.FullName);

            Console.WriteLine("Class Name is: " + type.Name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood analyser");
            CustomerClassReflections();
        }
    }
}
