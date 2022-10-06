using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;
using FluentAssertions;

namespace API_Interactive_Lab_1.Tests.Constrollers
{
    public class HomeControllerTests
    {
        private HomeController _homeController;

        [SetUp]
        public void Setup()
        {
            _homeController = new HomeController();
        }

        // this attribute tells NUnit to run this method as a test
        [Test]
        public void TestGetHome()
        {
            _homeController.Get().Should().Be("Welcome to the Drinks API!");
        }

    }
}
