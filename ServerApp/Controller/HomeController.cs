using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ServerApp.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController: ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hello from .NET!" });
        }

    }
}