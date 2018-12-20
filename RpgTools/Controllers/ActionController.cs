using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgTools.Business;
using RpgTools.Model;

namespace RpgTools.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private IActionBusiness _actionBusiness;

        public ActionController(IActionBusiness actionBusiness)
        {
            _actionBusiness = actionBusiness;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_actionBusiness.FindAll());
        }


        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            return Ok(_actionBusiness.FindById(id));
        }


        [HttpPost]
        public IActionResult Create([FromBody] ActionModel action)
        {
            if (action == null) return BadRequest();
            return Ok(_actionBusiness.Create(action));
        }


        [HttpPut]
        public IActionResult Update([FromBody] ActionModel action)
        {
            if (action == null) return BadRequest();
            return Ok(_actionBusiness.Update(action));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _actionBusiness.Delete(id);
            var json = new Dictionary<string, string>
            {
                {"Message", "Ação deletada da base com sucesso"}
            };
            var jsonSerialized = JsonConvert.SerializeObject(json);
            return Ok(jsonSerialized);
        }
    }
}
