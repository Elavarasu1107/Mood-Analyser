namespace MoodTesting
{
    public class Tests
    {
        [Test]
        public void GetInput_AnalyseMood_ReturnSad()
        {
            MoodAnalyser.Analyser analyser = new MoodAnalyser.Analyser();
            string moodInput = "I am in Sad Mood";
            Assert.AreEqual("Sad", analyser.Mood(moodInput));
        }
        [Test]
        public void GetInput_AnalyseAnyMood_ReturnHappy()
        {
            MoodAnalyser.Analyser analyser = new MoodAnalyser.Analyser();
            string moodInput = "I am in Any Mood";
            Assert.AreEqual("Happy", analyser.Mood(moodInput));
        }
    }
}