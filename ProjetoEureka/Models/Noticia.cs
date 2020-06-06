using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEureka.Models
{
    [Table("euk_noticia")]
    public class Noticia
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data_criacao { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Categoria_Id { get; set; }
        [ForeignKey("Categoria_Id")]
        public Categoria Categoria { get; set; }
        
    }
}
