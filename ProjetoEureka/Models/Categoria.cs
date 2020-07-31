using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEureka.Models
{
    [Table("euk_categoria", Schema = "eureka_animes")]
    public class Categoria
    {
        [Key]
        public int Cat_Id { get; set; }
        [Column("Categoria")]
        public string Nome { get; set; }
        public virtual ICollection<Noticia> Noticias { get; set; }

    }
}
