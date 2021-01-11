using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Identity.Web;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace DH.Enterprises.WebApi.Areas.Sites
{
    [ApiController]
    public class EnterpriseController : Controller
    {  
        [HttpGet]
        [Authorize]
        [Route("customers")]
        public IActionResult GetCustomersAsync()
        {
            return Ok("Second request!");
        }        
    }
}