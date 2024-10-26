using MathUtilitiesExample;

namespace UnitTests
{
    [TestClass]
    public class MathUtilitiesTests
    {
        [TestMethod]
        public void CalculateCircleArea_WithRadius5_ReturnsCorrectArea()
        {
            double result = MathUtilities.CalculateCircleArea(5);
            Assert.AreEqual(78.53975, result, 0.0001);
        }

        [TestMethod]
        public void CalculateSquareRoot_WithNumber16_Returns4()
        {
            double result = MathUtilities.CalculateSquareRoot(16);
            Assert.AreEqual(4, result);
        }
    }

}
