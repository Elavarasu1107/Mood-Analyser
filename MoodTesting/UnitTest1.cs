namespace MoodAnalyser
{
    public class Tests
    {
        [Test]
        public void GivenNullAsInput_AnalyseMood_ThrowNullException()
        {
            try
            {
                string moodInput = null;
                MoodAnalyser.Analyser analyser = new MoodAnalyser.Analyser(moodInput);
                string output = analyser.Mood();
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Message should not be Null", ex.Message);
            }   
        }
        [Test]
        public void GivenEmptyAsInput_AnalyseMood_ThrowEmptyException()
        {
            try
            {
                string moodInput = "";
                MoodAnalyser.Analyser analyser = new MoodAnalyser.Analyser(moodInput);
                string output = analyser.Mood();
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Message should not be Empty", ex.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassNameAsInput_ShouldReturnMoodAnalyserObject()
        {
            string message = null;
            object expected = new Analyser(message);
            object actual = MoodAnalyserFactory.MoodObject("MoodAnalyser.Analyser", "MoodAnalyser.Analyser");
            expected.Equals(actual);
        }
        [Test]
        public void GivenImproperClassName_ShouldthrowNoSuchClassException()
        {
            try
            {
                string message = null;
                object expected = new Analyser(message);
                object actual = MoodAnalyserFactory.MoodObject("MoodAnalyser.An", "MoodAnalyser.Analyser");
                expected.Equals(actual);
            }
            catch(Exception ex)
            {
                Assert.AreEqual("Class Not Found", ex.Message);
            }
            
        }
    }
}