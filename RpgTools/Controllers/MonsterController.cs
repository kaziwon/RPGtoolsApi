using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgTools.Business;

namespace RpgTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : ControllerBase
    {
        private IMonsterBusiness _monsterBusiness;
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_monsterBusiness.FindAll());
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
