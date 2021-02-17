using System.ComponentModel.DataAnnotations.Schema;

namespace eurekaanimes5.Models
{
    [Table("animestags")]
    public class AnimesTags
    {
        public int AnimeID { get; set; }
        public int TagsTagID { get; set; }
    }
}