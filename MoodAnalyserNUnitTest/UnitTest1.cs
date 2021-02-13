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
        /// TC1.2 Given "I am in any mood " message shoud return HAPPY
        /// </summary>
        [Test]
        public void HappyMoodMessageShoudReturnHappy()
        {
            string happyMessage = "I am in any mood";
            string expected = "HAPPY";
            string actual = moodAnalyserClass.MoodAnalyserMethod(happyMessage);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC2.1Given Null mood should return Happy
        /// </summary>
        [Test]
        public void GivenMessageWhenNullShouldReturnHappy()
        {
            string expected = "HAPPY";
            string actual = moodAnalyserClass.MoodAnalyserMethod(null);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TU3.1 Given Null mood should throw moodAnalyser exception
        /// </summary>
        [Test]
        public void GivenMessageWhenNullUsingCustomExceptionShouldReturnNullMood()
        {
            string message = null;
            try
            {
                moodAnalyserClass = new MoodAnalyserClass(message);
                string result = moodAnalyserClass.MoodAnalyseNullAndEmpty();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);
            }
        }
        /// <summary>
        /// 3.2 given empty mood shoud throws moodAnalyser exception
        /// </summary>
        [Test]
        public void GivenMessageWhenEmptyUsingCustomExceptionShouldReturnEmptyMood()
        {
            string message = "";
            try
            {
                moodAnalyserClass = new MoodAnalyserClass(message);
                string result = moodAnalyserClass.MoodAnalyseNullAndEmpty();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual("Mood should not be empty", exception.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyseClassNameShouldReturnMoodAnalyseObject()
        {
            object expected = new MoodAnalyserClass();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserNameSpace.MoodAnalyserClass", "MoodAnalyserClass");
            expected.Equals(obj);
        }
        [Test]
        public void GivenMoodAnalyseClassNameShouldReturnMoodAnalyseObjectUsingParameterisedConstructor()
        {
            object expected = new MoodAnalyserClass("Happy");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyserNameSpace.MoodAnalyserClass", "MoodAnalyserClass", "Happy");
            expected.Equals(obj);
        }
        [Test]
        public void GivenHappyMood_ShouldReturnHappy()
        {
            object expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMethod("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }
    }
}