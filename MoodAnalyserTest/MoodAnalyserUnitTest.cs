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
        [Test]
        public void GivenMoodAnalyser_ShouldReturnMoodAnalyserObject()
        {
            object expected = new Analyser("Happy");
            object actual = MoodAnalyserFactory.ParameterizedConstructor("MoodAnalyser.Analyser", "Analyser", "Happy");
            expected.Equals(actual);
        }

        [Test]

        public void GivenMoodAnalyserWrongClassName_ShouldThrowMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyserFactory.ParameterizedConstructor("MoodAnalyser.Analyser", "MoodAnalyser", "Happy");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [Test]

        public void GivenMoodAnalyserClassNameWithNoProperConstructor_ShouldThrowMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyserFactory.ParameterizedConstructor("MoodAnalyser.Analyser", "Analyser", "I am happy");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        [Test]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {
            //Arrange
            string className = "MoodAnalyzer.MoodAnalyser";
            string constructor = "MoodAnalyser";
            Analyser expectedObj = new Analyser("HAPPY");
            //Act
            object resultObj = MoodAnalyserFactory.ParameterizedConstructor(className, constructor, "HAPPY");
            //Assert
            expectedObj.Equals(resultObj);
        }
        //TestCase-6.2
        [Test]
        public void Given_Wrong_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                Analyser expectedObj = new Analyser("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.ParameterizedConstructor(className, constructorName, "HAPPY");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        //TC 6.3:-Pass Wrong Constructor parameter, cactch the Exception and throw indicating No such method Error
        [Test]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                Analyser expectedObj = new Analyser("HAPPY");
                //Act
                object resultObj = MoodAnalyserFactory.ParameterizedConstructor(className, constructorName, "HAPPY");
            }
            catch (CustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", e.Message);
            }
        }
    }
}