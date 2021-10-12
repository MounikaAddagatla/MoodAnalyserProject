using MoodAnalyser;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUnitTest
    {

        [Test]
        public void GivenSad_ShouldReturn_SadMood()
        {
            Analyser mood = new Analyser("I am in sad mood ");
            string result = mood.Analyzer();
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void GivenAny_ShouldReturn_HappyMood()
        {
            Analyser mood = new Analyser("I am in any Mood");
            string result = mood.Analyzer();
            Assert.AreEqual("HAPPY", result);
        }
    }
}