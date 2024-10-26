using GlobalConstantsExample;

namespace UnitTests
{
    [TestClass]
    public class GlobalConstantsTests
    {
        [TestMethod]
        public void TaxRate_ShouldBe0_15()
        {
            Assert.AreEqual(0.15, GlobalConstants.TaxRate);
        }

        [TestMethod]
        public void CurrencySymbol_ShouldBeDollarSign()
        {
            Assert.AreEqual("$", GlobalConstants.CurrencySymbol);
        }
    }

}
