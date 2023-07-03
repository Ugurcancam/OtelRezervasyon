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
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService) => _serviceService = serviceService;

        [HttpGet]
        public IActionResult ListService()
        {
            var values = _serviceService.BGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.BInsert(service);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.BGetById(id);
            _serviceService.BDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.BUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var values = _serviceService.BGetById(id);
            return Ok(values);
        }              
    }
}