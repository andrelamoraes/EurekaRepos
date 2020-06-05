using Microsoft.EntityFrameworkCore;
using ProjetoEureka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEureka.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions <Context> options) : base(options)
        {

        }
        public DbSet<Noticia> euk_noticia { get; set; }
        public DbSet<Categoria> euk_categoria { get; set; }

    }
}
