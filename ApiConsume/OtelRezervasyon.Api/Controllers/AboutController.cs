using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListAbout()
        {
            var values = _aboutService.BGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About room)
        {
            _aboutService.BInsert(room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.BGetById(id);
            _aboutService.BDelete(values);            
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About room)
        {
            _aboutService.BUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.BGetById(id);
            return Ok();
        }        
    }
}