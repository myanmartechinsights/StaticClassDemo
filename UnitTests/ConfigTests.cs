using ConfigExample;

namespace UnitTests
{
    [TestClass]
    public class ConfigTests
    {
        [TestMethod]
        public void DatabaseConnectionString_ShouldNotBeNullOrEmpty()
        {
            Assert.IsFalse(string.IsNullOrEmpty(Config.DatabaseConnectionString));
        }
    }

}
