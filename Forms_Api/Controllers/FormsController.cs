using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Forms_Api.Models;

namespace Forms_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController : ControllerBase
    {
        [HttpGet]
        public UserInfo GetFormValues()
        {
            return new UserInfo { FirstName = "Rony", LastName = "Das" };
        }

        [HttpPost("saveUser")]
        public IActionResult saveForm([FromBody]UserInfo userInfo)
        {

            string fileName = @"D:\Learnings\userForm\Forms_Api\Forms_Api\UserData.txt";
            System.IO.File.WriteAllText(fileName, JsonConvert.SerializeObject(userInfo));

            return Ok(userInfo);

        }
    }
}