namespace MoodTesting
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
    }
}