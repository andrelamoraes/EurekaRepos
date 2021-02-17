using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eurekaanimes5.Models
{
    public class Tags
    {
        [Key]
        public int TagID { get; set; }
        public string TagName { get; set; }
        public ICollection<Animes> Anime { get; set; }
        public ICollection<Noticias> Noticia { get; set; }
    }
}