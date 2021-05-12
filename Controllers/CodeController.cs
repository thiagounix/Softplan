using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftPLan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeController : Controller
    {
        [HttpGet("showmethecode")]
        public string showmethecode()
        {
            return "https://github.com/thiagounix/Softplan";
        }
    }
}
