using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODEB_DotnetCore_Project.BusinessLayer.Abstract;
using TODEB_DotnetCore_Project.EntityLayer.Entities.Concrete;

namespace TODEB_DotnetCore_Project.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            var response = _service.Insert(customer);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(Customer customer)
        {
            var response = _service.Update(customer);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(Customer customer)
        {
            var response = _service.Delete(customer);
            return Ok(response);
        }
    }
}
