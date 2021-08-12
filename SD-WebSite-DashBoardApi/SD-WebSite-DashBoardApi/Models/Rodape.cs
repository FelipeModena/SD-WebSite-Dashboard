using SD_WebSite_DashBoardApi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models
{
    public class Rodape : BaseEntity
    {
        [Column("administrador")]
        public Administrador Administrador { get; set; }
        [Column("rodape_ativo")]
        public bool RodapeAtivo { get; set; }
        [Column("cor_fundo")]
        public string CorFundo { get; set; }
        [Column("icones_redes_sociais")]
        public string IconesRedesSociais { get; set; }
        [Column("logo")]
        public string Logo { get; set; }
        [Column("modificacao")]
        public DateTime Modificacao { get; set; }
    }
}
