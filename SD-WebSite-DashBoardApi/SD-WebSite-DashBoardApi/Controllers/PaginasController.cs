﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    public class PaginasController : ControllerBase
    {
        private readonly IPaginaBusiness _paginaBusiness;

        public PaginasController(IPaginaBusiness paginaBusiness)
        {
            _paginaBusiness = paginaBusiness;
        }



        [HttpGet ("GetAllPagesAndComponents")]
        public IActionResult GetAllPagesAndComponents()
        {
            var pagina = Ok(_paginaBusiness.FindAllPagesAndComponents());
            if (pagina == null)
            {
                return Ok("vazia");
            }
            return (pagina);
        }


        [HttpPut ("updatePaginas")]
        public IActionResult UpdatePaginas([FromBody] List<Pagina> paginas)
        {
            if (paginas == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(_paginaBusiness.UpdatePages(paginas));
            }
        }

    }
}