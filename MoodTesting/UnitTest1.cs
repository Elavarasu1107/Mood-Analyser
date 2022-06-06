namespace MoodTesting
{
    public class Tests
    {
        [Test]
        public void GetInput_AnalyseMood_ReturnResult()
        {
            MoodAnalyser.Analyser analyser = new MoodAnalyser.Analyser();
            string moodInput = "I am in Sad Mood";
            Assert.AreEqual("Sad", analyser.Mood(moodInput));
        }
    }
}