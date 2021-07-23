using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Controllers
{
    [ApiController]
    public class SDAdministradorController : ControllerBase
    {
        [HttpPut("Index")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
