using Microsoft.AspNetCore.Mvc;
using SD_WebSite_DashBoardApi.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RootController : ControllerBase
    {
        private readonly IRootBusiness _rootBusiness;

        public RootController(IRootBusiness rootBusiness)
        {
            _rootBusiness = rootBusiness;
        }

        [HttpPost("CreateNewUser")]
        public IActionResult CreateNewUser(string usuario,string senha,int template)
        {
            if (template>=1 || template<=3)
            {
            var user = _rootBusiness.CreateUser(usuario,senha,template);
            return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("DeleteUSer")]
        public IActionResult DeleteUSer( int id)
        {
            return Ok(_rootBusiness.DeleteUser(id));
        }
    }
}
