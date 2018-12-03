using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RpgTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(0);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("oi");
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(0);
        }

       
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok(0);
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(0);
        }
    }
}
