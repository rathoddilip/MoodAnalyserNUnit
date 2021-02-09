using NUnit.Framework;
using MoodAnalyserNameSpace;
namespace MoodAnalyserNUnitTest
{
    public class Tests
    { 
        MoodAnalyserClass moodAnalyserClass;
        
        [SetUp]
        public void Setup()
        {
            moodAnalyserClass = new MoodAnalyserClass();
        }

        
        [Test]
        public void SadMoodMessageShoudReturnSad()
        {
            string sadMessage = "I am in sad mood";
            string expected = "SAD";
            string actual=moodAnalyserClass.MoodAnalyserMethod(sadMessage);
            Assert.AreEqual(expected, actual);
        }
        
       
    }
}