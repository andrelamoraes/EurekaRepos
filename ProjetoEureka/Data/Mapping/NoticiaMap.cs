using ProjetoEureka.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEureka.Data.Mapping
{
    public class NoticiaMap : EntityTypeConfiguration<Noticia>
    {
        public NoticiaMap()
        {
            ToTable("euk_noticia");
            HasKey(x => x.Id);

        }
    }
}
