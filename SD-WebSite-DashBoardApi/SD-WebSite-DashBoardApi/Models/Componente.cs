using SD_WebSite_DashBoardApi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models
{
    [Table ("componente")]
    public class Componente:BaseEntity
    {
        [Column("tipo_componente")]
        public string TipoComponente { get; set; }
        //[Column("adminstrador_id")]
        //public virtual List<Administrador> AdministradorId { get; set; }
        [Column("pagina_id")]
        public long  PaginaId { get; set; }
        public virtual Pagina Pagina { get; set; }
        [Column("url_imagem")]
        public string UrlImagem { get; set; }
        [Column("titulo")]
        public string Titulo { get; set; }
        [Column("cor_titulo")]
        public string CorTitulo { get; set; }
        [Column("sub_titulo")]
        public string SubTitulo { get; set; }
        [Column("cor_sub_titulo")]
        public string CorSubTitulo { get; set; }
        [Column("texto")]
        public string Texto { get; set; }
        [Column("url_botao_1")]
        public string UrlBotao1 { get; set; }
        [Column("txt_botao_1")]
        public string TxtBotao1 { get; set; }
        [Column("cor_botao_1")]
        public string CorBotao1 { get; set; }
        [Column("url_direcionamento_paginas")]
        public string UrlDirecionamentoPaginas { get; set; }


    }
}
