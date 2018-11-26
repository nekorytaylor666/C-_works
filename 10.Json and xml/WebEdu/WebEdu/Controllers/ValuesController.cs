
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSchoolApi.Models;

namespace WebSchoolApi.Controllers
{
    [Route("api/schools")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        Firebase firebase = new Firebase();
            // GET api/values
        [HttpGet]
        public string Get()
        {
            return firebase.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return firebase.Get(id);
        }
        [HttpGet("search/{search}")]
        public ActionResult<string> Get(string search)
        {
            return firebase.Get(search);
        }
        [HttpGet("topten")]
        public ActionResult<string> GetTop()
        {
            return firebase.Top();
        }
    }
}
