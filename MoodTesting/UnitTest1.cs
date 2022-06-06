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
    }
}