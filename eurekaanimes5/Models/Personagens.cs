using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eurekaanimes5.Models
{
    public class Personagens
    {
        [Key]
        public int PersonagemID { get; set; }
        public string Name { get; set; }
        public string Actor { get; set; }
        public int AnimeID { get; set; }
        public Animes Anime { get; set; }
    }
}