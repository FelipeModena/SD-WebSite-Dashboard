using SD_WebSite_DashBoardApi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models
{
    public class Imagem:BaseEntity
    {
        [Column ("componente")]
        public Componente Componente{ get; set; }
        [Column ("img_url")]
       public string ImgUrl { get; set; }
        [Column ("texto")]
        public string Texto { get; set; }
        [Column ("compatibilidade")]
        public string Compatibilidade { get; set; }
        [Column ("ordenacao")]
        public int Ordenacao { get; set; }
    }
}
