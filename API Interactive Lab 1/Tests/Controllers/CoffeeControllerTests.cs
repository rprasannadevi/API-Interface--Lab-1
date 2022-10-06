using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;
using FluentAssertions;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        private CoffeeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new CoffeeController();
        }

        [Test]
        public void Test_Get_CoffeeLover()
        {
            _controller.GetCoffeeLover().Should().Be("I like coffee!");
        }


        [Test]
        public void Test_Get_Coffee_No_Params()
        {
            var result = _controller.Get(null);
            result.Name.Should().Be("latte");
            result.Id.Should().Be(-1);
        }

        [Test]
        public void Test_Get_Coffee_By_Name()
        {
            var result = _controller.Get("cappuccino");
            result.Name.Should().Be("cappuccino");
            result.Id.Should().Be(7);
         }
    }
}

