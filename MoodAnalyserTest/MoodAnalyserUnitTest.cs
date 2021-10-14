using MoodAnalyser;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUnitTest
    {

        [Test]
        public void GivenSad_ShouldReturn_SadMood()
        {
            Analyser test = new Analyser("I am in sad mood ");
            string result = test.Analyzer();
            Assert.AreEqual("SAD", result);
        }
        [Test]
        public void GivenAny_ShouldReturn_HappyMood()
        {
            Analyser test = new Analyser("I am in any Mood");
            string result = test.Analyzer();
            Assert.AreEqual("HAPPY", result);
        }
        [Test]
        public void GivenNull_ShouldReturn_HappyMood()
        {
            Analyser test = new Analyser(null);
            string result = test.Analyzer();
            Assert.AreEqual("HAPPY", result);
        }
    }
}