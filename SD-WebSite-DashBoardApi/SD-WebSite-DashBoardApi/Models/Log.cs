using SD_WebSite_DashBoardApi.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models
{
    [Table("log")]
    public class Log:BaseEntity
    {
        [Column("data")]
        public DateTime Data { get; set; }
        [Column("table")]
        public string Table { get; set; }
        [Column("error")]
        public string Error { get; set; }
    }
}
