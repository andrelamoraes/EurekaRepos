using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEureka.Models
{
    [Table("euk_tags", Schema = "eureka_animes")]
    public class Tag
    {
        public int Id { get; set; }
        public string Tags { get; set; }
    }
}