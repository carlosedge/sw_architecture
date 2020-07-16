using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Queueing;
using Queueing.Models;

namespace QueueExampleApiClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private readonly IProducer _producer;

        public ProducerController(IProducer producer)
        {
            _producer = producer ?? throw new NullReferenceException();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Create(Message message)
        {
            _producer.Produce(message);
            return StatusCode(201,"Post executed sucessfully");
        }
    }
}
