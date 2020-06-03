using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiToolkit.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomGeneratorController : ControllerBase
    {
        private readonly ILogger<RandomGeneratorController> _logger;

        public RandomGeneratorController(ILogger<RandomGeneratorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get([FromQuery] int min = 1, int max = 10)
        {
            return RandomNumber(min, max).ToString();
        }

        private int RandomNumber(int min, int max)
        {            
            if (min > max)
            {
                throw new InvalidOperationException("Min number muest be less than Max");
            }
            return new Random().Next(min, max);
        }
    }

}
