using LoggerExample;

namespace UnitTests
{
    [TestClass]
    public class LoggerTests
    {
        [TestMethod]
        public void LogError_ShouldWriteMessageToConsole()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Logger.LogError("Test Error");

                Assert.IsTrue(sw.ToString().Contains("Error: Test Error"));
            }
        }
    }

}
