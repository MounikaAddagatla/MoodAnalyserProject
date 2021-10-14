using MoodAnalyser;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUnitTest
    {
        [Test]
        public void GivenAnalyserClassName_ShouldReturnAnalyserObject()
        {
            object expected = new Analyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.Analyser", "Analyser");
            expected.Equals(obj);

        }
        [Test]
        public void GivenWrongClassName_ShouldThrowException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.Analyser", "Analyser");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        [Test]
        public void GivenClassConstructerNotProper_ShouldThrowException()
        {
            string expected = "Constructor not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.Analyser", "Analyser");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}