using API_Interactive_Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            var coffee = new Coffee();
            if (name != null)
            {
                coffee.Name = name;
                coffee.Id = 7;
            }
            else
            {
                coffee.Name = "latte";
                coffee.Id = -1;
            }
            return coffee;
        }

        [HttpGet("lover")]
        public string Get()
        {
            return "I like coffee!";
        }
    }
}
