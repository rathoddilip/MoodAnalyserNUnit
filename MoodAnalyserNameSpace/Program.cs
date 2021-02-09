using System;

namespace MoodAnalyserNameSpace
{
   public class MoodAnalyserClass
    {
        
        public MoodAnalyserClass()
        {
           
        }
        public string MoodAnalyserMethod(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }

    
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood analyser");
        }
    }
}
