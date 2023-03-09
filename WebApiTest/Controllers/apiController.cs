using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTest.Models;
using WebApiTest.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("api")]
    public class apiController : ControllerBase
    {
        public API Api { get; set; }

        [HttpGet("123")]
        public IActionResult Index()
        {
            return Content("102348");
        }
    }
}
