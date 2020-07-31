using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEureka.Models
{
    [Table("euk_favpage", Schema = "eureka_animes")]
    public class Favoritos
    {
        public int Id { get; set; }
        public string Add_to_library { get; set; }
        public int UserId { get; set; }
        public int AnimeId { get; set; }
    }
}