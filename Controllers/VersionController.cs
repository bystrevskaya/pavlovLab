using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;
using System.Reflection;

namespace lab1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class VersionController : ControllerBase
    {
       // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
           return Ok(Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion);
        }
    }
}