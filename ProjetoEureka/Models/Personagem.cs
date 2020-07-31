using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEureka.Models
{
    [Table("euk_personagens", Schema = "eureka_animes")]
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Dublador { get; set; }
        public byte[] Personagem_avatar { get; set; }
        public int AnimeId { get; set; }
        public Anime _Anime { get; set; }
    }
}