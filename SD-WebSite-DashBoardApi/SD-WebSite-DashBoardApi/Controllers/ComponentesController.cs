using Microsoft.AspNetCore.Mvc;
using SD_WebSite_DashBoardApi.Business;
using SD_WebSite_DashBoardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ComponentesController : ControllerBase
    {
        private readonly IComponenteBusiness _componenteBusiness;

        public ComponentesController(IComponenteBusiness componenteBusiness)
        {
            _componenteBusiness = componenteBusiness;
        }
        [HttpPut("updateComponente")]
        public IActionResult UpdateComponente(Componente componente)
        {
            return Ok(_componenteBusiness.UpdateComponente(componente));
        }
    }
}
