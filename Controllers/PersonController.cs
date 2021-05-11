using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BileApi.Service;
using BileApi.Models;

namespace BileApi.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        [Route("[controller]")]
        public IActionResult Post([FromBody] Person person)
        {
            try
            {
                var res = _personService.Create(person);

                if (res == 0)
                    return NotFound();

                return Created("/Person/Post", res);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

        }

        [HttpGet]
        [Route("[controller]")]
        public IActionResult  Get()
        {
            try
            {
                var data = _personService.Read();

                return Ok(data);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public IActionResult GetById(int id)
        
        {
            try
            {
                var data = _personService.ReadById(id);

                return Ok(data);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

        }


        [HttpPut]
        [Route("[controller]/{id}")]
        public IActionResult Put(int id, [FromBody] Person person)
        {
            try
            {
                var res = _personService.Update(id, person);

                return Ok(res);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpDelete]
        [Route("[controller]/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var res = _personService.Delete(id);
                if (res == 0) {
                    return NotFound();
                }
                return Ok(res);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

    }
}
