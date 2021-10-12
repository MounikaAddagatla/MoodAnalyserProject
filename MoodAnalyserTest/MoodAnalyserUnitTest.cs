using MoodAnalyser;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUnitTest
    {

        [Test]
        public void GivenSad_ShouldReturn_SadMood()
        {
            Analyser mood = new Analyser();
            string result = mood.Analyzer("I am in sad Mood");
            Assert.AreEqual("sad", result);
        }
        [Test]
        public void GivenAny_ShouldReturn_HappyMood()
        {
            Analyser mood = new Analyser();
            string result = mood.Analyzer("I am in any Mood");
            Assert.AreEqual("happy", result);
        }
    }
}