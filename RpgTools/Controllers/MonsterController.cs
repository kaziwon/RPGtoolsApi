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
    public class MonsterController : ControllerBase
    {
        private IMonsterBusiness _monsterBusiness;

        public MonsterController(IMonsterBusiness monsterBusiness)
        {
            _monsterBusiness = monsterBusiness;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            var serializer = new JsonSerializerSettings();
            serializer.ReferenceLoopHandling =  Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            return new JsonResult  ( _monsterBusiness.FindAll(), serializer);
        }


        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var serializer = new JsonSerializerSettings();
            serializer.ReferenceLoopHandling =  Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            return new JsonResult(_monsterBusiness.FindById(id), serializer);
        }


        [HttpPost]
        public IActionResult Create([FromBody] MonsterModel monster)
        {
            if (monster == null) return BadRequest();
            return Ok(_monsterBusiness.Create(monster));
        }


        [HttpPut]
        public IActionResult Update([FromBody] MonsterModel monster)
        {
            var serializer = new JsonSerializerSettings();
            serializer.ReferenceLoopHandling =  Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            return new JsonResult(_monsterBusiness.Update(monster), serializer);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _monsterBusiness.Delete(id);
            var json = new Dictionary<string, string>
            {
                {"Message", "Monstro deletado da base com sucesso"}
            };
            var jsonSerialized = JsonConvert.SerializeObject(json);
            return Ok(jsonSerialized);
        }
    }
}
