using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.Business.Abstract;

namespace OtelRezervasyon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult ListRoom()
        {
            var values = _roomService.BGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom()
        {
            return Ok();
        }

    }
}