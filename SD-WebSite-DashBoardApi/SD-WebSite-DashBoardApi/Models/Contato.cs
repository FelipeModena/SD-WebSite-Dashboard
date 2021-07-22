using SD_WebSite_DashBoardApi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models
{
    [Table("contato")]
    public class Contato : BaseEntity
    {
        [Column("administrador")]
        public Administrador Administrador { get; set; }
        [Column("endereco")]
        public string Endereco { get; set; }
        [Column("cidade")]
        public string Cidade { get; set; }
        [Column("bairro")]
        public string Bairro { get; set; }
        [Column("estado")]
        public string Estado { get; set; }
        [Column("complemento")]
        public string Complemento { get; set; }
        [Column("whatsapp")]
        public string Whatsapp { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("facebook")]
        public string Facebook { get; set; }
        [Column("instagram")]
        public string Instagram { get; set; }
        [Column("linkedin")]
        public string Linkedin { get; set; }
        [Column("youtube")]
        public string Youtube { get; set; }

        [Column("modificacao")]
        public DateTime Modificacao { get; set; }
    }
}
