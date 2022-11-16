using SteveLabs.DockerBuildTest.Service;

namespace SteveLabs.DockerBuildTest.MSTest
{
    [TestClass]
    public class GreetingServiceTests
    {
        [TestMethod]
        public void GivenGreet_WhenCalled_ThenReturnsHello()
        {
            var target = new GreetingService();
            var expected = "Hello";
            var actual = target.Greet();

            Assert.AreEqual(expected, actual);
        }
    }
}