using StringHelperExample;


namespace UnitTests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void IsNullOrEmpty_WithNull_ReturnsTrue()
        {
            Assert.IsTrue(StringHelper.IsNullOrEmpty(null));
        }

        [TestMethod]
        public void CapitalizeFirstLetter_WithLowerCaseString_ReturnsCapitalizedString()
        {
            Assert.AreEqual("Hello", StringHelper.CapitalizeFirstLetter("hello"));
        }
    }

}
