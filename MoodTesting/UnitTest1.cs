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
        [Test]
        public void GetInputAsHappy_AnalyseMood_ReturnHappy()
        {
            string moodInput = "I am in Any Mood";
            MoodAnalyser.Analyser analyser = new MoodAnalyser.Analyser(moodInput);
            Assert.AreEqual("Happy", analyser.Mood());
        }
    }
}