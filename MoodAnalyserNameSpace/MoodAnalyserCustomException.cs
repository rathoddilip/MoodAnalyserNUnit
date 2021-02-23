using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserNameSpace
{
    public class MoodAnalyserCustomException :Exception
    {
        public enum ExceptionType
        {
            EMPTY_MOOD, NULL_MOOD,
            CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND,
        }

        public ExceptionType exceptionType;
        public MoodAnalyserCustomException(ExceptionType type, string message):base(message)
        {
            this.exceptionType = exceptionType;

        }
    }
}
