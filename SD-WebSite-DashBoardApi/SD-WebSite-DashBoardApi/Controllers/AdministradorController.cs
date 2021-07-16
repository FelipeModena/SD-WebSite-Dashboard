﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SD_WebSite_DashBoardApi.Business;
using SD_WebSite_DashBoardApi.Data;
using SD_WebSite_DashBoardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {
        private readonly IAdminstradorBusiness _administradorBusiness;
        private readonly IConfiguracaoBusiness configuracaoBusiness;

        public AdministradorController(IAdminstradorBusiness adminstradorBusiness, IConfiguracaoBusiness configuracaoBusiness = null)
        {
            _administradorBusiness = adminstradorBusiness;
            this.configuracaoBusiness = configuracaoBusiness;
        }

        [HttpGet("login")]
        public IActionResult Login(string user, string password)
        {
            return Ok(_administradorBusiness.FindByUser(user,password));
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var administrador = _administradorBusiness.FindById(id);
            return Ok(administrador);
        }

        [HttpGet("getConfiguracoes")]
        public IActionResult GetConfiguracoes()
        {
            return Ok(configuracaoBusiness.FindLast());
           
        }

        [HttpPut ("configureRodape")]
        public IActionResult ConfigureRodape([FromBody] Rodape rodape)
        {
            if (rodape == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(configuracaoBusiness.UpdateRodape(rodape));
            }
        }

        [HttpPut("configureContato")]
        public IActionResult ConfigureContato([FromBody] Contato contato)
        {
            if (contato == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(configuracaoBusiness.UpdateContato(contato));
            }
        }
    }
}
