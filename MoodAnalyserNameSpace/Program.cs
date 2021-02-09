using System;

namespace MoodAnalyserNameSpace
{
    public class MoodAnalyserClass
    {
        string message;
        /// <summary>
        /// Refractor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyserClass(string message)
        {
            this.message = message;
        }
        public MoodAnalyserClass()
        {
            
        }
       
        public string MoodAnalyserMethod(string message)
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)//Handled the null Exception
            {
                return "HAPPY";
            }
        }
    
    
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood analyser");
        }
    }
}
