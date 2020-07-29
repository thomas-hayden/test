using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = new HomeController();
            var test2 = test.About();
            Assert.IsNotNull(test2);
        }
    }
}
