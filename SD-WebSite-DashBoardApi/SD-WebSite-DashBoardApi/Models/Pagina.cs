using SD_WebSite_DashBoardApi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models
{
    [Table("pagina")]
    public class Pagina:BaseEntity
    {
        [Column("nome_pagina")]
        public string NomePagina { get; set; }
        [Column("ordem")]
        public int Ordem { get; set; }
        [Column("ativa")]
        public bool Ativa { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("componente")]
        public virtual List<Componente> Componente { get; set; }
        [Column("modificacao")]
        public DateTime Modificacao { get; set; }
    }
}
