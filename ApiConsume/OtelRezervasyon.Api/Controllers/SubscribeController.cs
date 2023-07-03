using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscribeController : ControllerBase
    {
        [HttpGet]
        public IActionResult ListSubscribe()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddSubscribe()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteSubscribe()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateSubscribe()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSubscribe()
        {
            return Ok();
        }
    }
}