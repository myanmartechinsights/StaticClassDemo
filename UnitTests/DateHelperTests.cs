using DateHelperExample;

namespace UnitTests
{
    [TestClass]
    public class DateHelperTests
    {
        [TestMethod]
        public void IsWeekend_WithSaturday_ReturnsTrue()
        {
            DateTime saturday = new DateTime(2024, 10, 26);
            Assert.IsTrue(DateHelper.IsWeekend(saturday));
        }

        [TestMethod]
        public void GetDaysDifference_WithTwoDates_ReturnsCorrectDifference()
        {
            DateTime start = new DateTime(2024, 1, 1);
            DateTime end = new DateTime(2024, 1, 31);
            Assert.AreEqual(30, DateHelper.GetDaysDifference(start, end));
        }
    }

}
