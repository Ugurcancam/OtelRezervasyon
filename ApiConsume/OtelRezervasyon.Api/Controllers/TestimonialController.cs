using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.Business.Abstract;
using OtelRezervasyon.Entity.Concrete;

namespace OtelRezervasyon.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult ListTestimonial()
        {
            var values = _testimonialService.BGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.BInsert(testimonial);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.BGetById(id);
            _testimonialService.BDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.BUpdate(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.BGetById(id);
            return Ok(values);
        }          
    }
}