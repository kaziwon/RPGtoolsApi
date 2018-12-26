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
    public class StatusController : ControllerBase
    {
        private IStatusBusiness _statusbusiness;

        public StatusController(IStatusBusiness statusBusiness)
        {
            _statusbusiness = statusBusiness;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(_statusbusiness.FindAll());
        }


        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            return Ok(_statusbusiness.FindById(id));
        }


        [HttpPost]
        public IActionResult Create([FromBody] StatusModel status)
        {
            if (status == null) return BadRequest();
            return Ok(_statusbusiness.Create(status));
        }


        [HttpPut]
        public IActionResult Update([FromBody] StatusModel status)
        {
            return Ok(_statusbusiness.Update(status));
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _statusbusiness.Delete(id);
            var json = new Dictionary<string, string>
            {
                {"Message", "Status deletado da base com sucesso"}
            };
            var jsonSerialized = JsonConvert.SerializeObject(json);
            return Ok(jsonSerialized);
        }
    }
}
