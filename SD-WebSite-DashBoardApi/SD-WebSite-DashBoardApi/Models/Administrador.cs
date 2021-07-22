﻿using SD_WebSite_DashBoardApi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models
{
    [Table ("adminstrador")]
    public class Administrador:BaseEntity
    {
        [Column("usuario")]
        public string Usuario { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("url_site")]
        public string UrlSite { get; set; }
        [Column("modelo_site")]
        public string ModeloSite { get; set; }
        public virtual List<Pagina> Pagina { get; set; }

    }
}
