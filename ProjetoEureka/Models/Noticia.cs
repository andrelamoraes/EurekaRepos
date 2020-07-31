using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEureka.Models
{
    [Table("euk_noticias", Schema = "eureka_animes")]
    //     public class Noticia
    //     {
    //         [Key]
    //         public int Id_Noticia { get; set; }
    //         public DateTime Data_criacao { get; set; }
    //         public string Titulo { get; set; }
    //         public string Descricao { get; set; }
    //         [ForeignKey("_Categoria")]
    //         public int Id_Categoria { get; set; }
    //         public virtual Categoria _Categoria { get; set; }

    //     }
    // }
    public class Noticia
    {
        [Key]
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public DateTime Data_Criacao { get; set; }
        public string Descricao { get; set; }
        //public byte?[] Capa_Noticia { get; set; }
        public string Meta_Key { get; set; }
        [Column("euk_user_Id")]
        public int UsuarioId { get; set; }
        [ForeignKey("_Categoria")]
        public int euk_categoria_Id { get; set; }
        public virtual Categoria _Categoria { get; set; }
        // public virtual User Usuario { get; set; }
    }
}
