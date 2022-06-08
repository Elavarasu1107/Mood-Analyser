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
            object expected = new Analyser();
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
        [Test]
        public void GivenImproperConstructorName_ShouldthrowNoSuchMethodException()
        {
            try
            {
                string message = null;
                object expected = new Analyser(message);
                object actual = MoodAnalyserFactory.MoodObject("MoodAnalyser.Analyser", "MoodAnalyser.analyser");
                expected.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Constructor Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassNameAsInput_ShouldReturnMoodAnalyserObject_usingParametrisedConstructor()
        {
            object expected = new Analyser("Happy");
            object actual = MoodAnalyserFactory.MoodAnalyserUsingParamaterisedConstructor("MoodAnalyser.Analyser", "Analyser", "Happy");
            expected.Equals(actual);
        }
        [Test]
        public void GivenImproperClassName_ShouldthrowNoSuchClassException_usingParameterisedConstructor()
        {
            try
            {
                object expected = new Analyser("Happy");
                object actual = MoodAnalyserFactory.MoodAnalyserUsingParamaterisedConstructor("MoodAnalyser.Analys", "Analyser", "Happy");
                expected.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Class Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenImproperConstructorName_ShouldthrowNoSuchMethodException_usingParameterisedConstructor()
        {
            try
            {
                object expected = new Analyser("Happy");
                object actual = MoodAnalyserFactory.MoodAnalyserUsingParamaterisedConstructor("MoodAnalyser.Analyser", "Analy", "Happy");
                expected.Equals(actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Constructor Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenHappyAsInput_shouldReturnHappy_UsingReflection()
        {
            string expected = "Happy";
            string actual = MoodAnalyser.MoodAnalyserFactory.InvokeMoodAnalyser("Happy", "Mood");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenImproperMethodName_shouldThrowNoSuchMethodException_UsingReflection()
        {
            try
            {
                string expected = "Happy";
                string actual = MoodAnalyser.MoodAnalyserFactory.InvokeMoodAnalyser("Happy", "Analyser");
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Method Not Found", ex.Message);
            }
        }
        [Test]
        public void GivenHappyAsInput_shouldReturnHappy_UsingDynamicMethod()
        {
            string expected = "Happy";
            string actual = MoodAnalyser.MoodAnalyserFactory.DynamicMood("Happy", "message");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenImproperSetField_shouldthrowNoSuchFieldException_UsingDynamicMethod()
        {
            try
            {
                string expected = "Happy";
                string actual = MoodAnalyser.MoodAnalyserFactory.DynamicMood("Happy", "mess");
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Field Not Found", ex.Message);
            }
        }
    }
}