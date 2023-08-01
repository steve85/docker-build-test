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

        [TestMethod]
        public void GivenGreetTo_WhenToArgumentNull_ThenThrowsArgumentNullException()
        {
            var target = new GreetingService();

            Assert.ThrowsException<ArgumentNullException>(() => target.GreetTo(null));
        }

        [TestMethod]
        public void GivenGreetTo_WhenToArgumentPassed_ThenGreetingReturned()
        {
            var target = new GreetingService();
            var expected = "Hello to you Billy";
            var actual = target.GreetTo("Billy");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenGreetFrom_WhenFromArgumentNull_ThenThrowsArgumentNullException()
        {
            var target = new GreetingService();

            Assert.ThrowsException<ArgumentNullException>(() => target.GreetFrom(null));
        }

        [TestMethod]
        public void GivenGreetToFrom_WhenToArgumentNull_ThenThrowsArgumentNullException()
        {
            var target = new GreetingService();

            Assert.ThrowsException<ArgumentNullException>(() => target.GreetToFrom(null, "from"));
        }

        [TestMethod]
        public void GivenGreetToFrom_WhenFromArgumentNull_ThenThrowsArgumentNullException()
        {
            var target = new GreetingService();

            Assert.ThrowsException<ArgumentNullException>(() => target.GreetToFrom("from", null));
        }
    }
}