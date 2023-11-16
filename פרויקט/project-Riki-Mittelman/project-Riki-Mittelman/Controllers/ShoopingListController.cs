﻿using Microsoft.AspNetCore.Mvc;
using project_Riki_Mittelman.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project_Riki_Mittelman.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoopingListController : ControllerBase
    {
        public static readonly List<ShoopingList> _list=new List<ShoopingList>();
        public static int i=0;
    
        // GET: api/<ShoopingListController>
        [HttpGet]
        public List<ShoopingList> Get()
        {
            return _list;
        }


        // GET: api/<ShoopingListController>
        [HttpGet("id")]
        public ActionResult Get(int id)
        {
            ShoopingList tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();
            return Ok(tmp);
        }

        // POST api/<ShoopingListController>
        [HttpPost]
        public void Post([FromBody] ShoopingList value)
        {
            value.Id = i++;
            _list.Add(value);
        }

        // PUT api/<ShoopingListController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ShoopingList value)
        {

            ShoopingList tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();
            tmp.Name = value.Name;
            tmp.Amount=value.Amount;
            return Ok();

        }

        // DELETE api/<ShoopingListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            ShoopingList tmp;
            tmp = _list.Find((x) => x.Id == id);
            if (tmp == null)
                return NotFound();
            _list.Remove(tmp);
            return Ok();
        }
    }
}
