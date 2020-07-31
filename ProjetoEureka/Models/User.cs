using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEureka.Models
{
    [Table("euk_user", Schema = "eureka_animes")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }
        public string Fav_Anime { get; set; }
    }
}