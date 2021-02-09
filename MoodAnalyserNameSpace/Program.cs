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
            catch (NullReferenceException)//Handled the null Exception
            {
                return "HAPPY";
            }
        }
        public string MoodAnalyseNullAndEmpty()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                }
                if (this.message.Equals("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MOOD, "Mood should not be null");
            }

        }
    

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood analyser");
        }
    }
}
