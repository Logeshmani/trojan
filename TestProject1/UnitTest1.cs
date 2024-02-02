using JenkinsTesting;
using JenkinsTesting.Controllers;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            HomeController hc = new HomeController();
           
            Assert.Pass();
        }
    }
}