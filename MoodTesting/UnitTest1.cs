namespace MoodTesting
{
    public class Tests
    {
        [Test]
        public void GetInputAsSad_AnalyseMood_ReturnSad()
        {
            string moodInput = "I am in Sad Mood";
            MoodAnalyser.Analyser analyser = new MoodAnalyser.Analyser(moodInput);
            Assert.AreEqual("Sad", analyser.Mood());
        }
    }
}