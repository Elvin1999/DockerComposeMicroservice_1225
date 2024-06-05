﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MicroserviceB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployersController : ControllerBase
    {
        // GET: api/<EmployersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Employer 1", "Employer 2" };
        }

        // GET api/<EmployersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}