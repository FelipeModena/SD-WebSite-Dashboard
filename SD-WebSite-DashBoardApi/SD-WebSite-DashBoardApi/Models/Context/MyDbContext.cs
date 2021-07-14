using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SD_WebSite_DashBoardApi.Models.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }

        public DbSet<Pagina> Pagina { get; set; }
        public DbSet<Componente> Componente { get; set; }
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Rodape> Rodape {get;set;}
        public DbSet<Log> Log {get;set;}
        public DbSet<Contato> Contato {get;set; }
    }
}
