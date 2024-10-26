using DatabaseConnectionExample;

namespace UnitTests
{
    [TestClass]
    public class DatabaseConnectionTests
    {
        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            var instance1 = DatabaseConnection.Instance;
            var instance2 = DatabaseConnection.Instance;

            Assert.AreSame(instance1, instance2);
        }
    }

}
