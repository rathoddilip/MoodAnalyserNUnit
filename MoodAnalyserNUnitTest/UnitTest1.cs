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

        /// <summary>
        /// TC1.1 Given "I am in sad mood " message shoud return SAD
        /// </summary>
        [Test]
        public void SadMoodMessageShoudReturnSad()
        {
            string sadMessage = "I am in sad mood";
            string expected = "SAD";
            string actual=moodAnalyserClass.MoodAnalyserMethod(sadMessage);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC1.1 Given "I am in any mood " message shoud return HAPPY
        /// </summary>
        [Test]
        public void HappyMoodMessageShoudReturnHappy()
        {
            string happyMessage = "I am in any mood";
            string expected = "HAPPY";
            string actual = moodAnalyserClass.MoodAnalyserMethod(happyMessage);
            Assert.AreEqual(expected, actual);
        }

    }
}