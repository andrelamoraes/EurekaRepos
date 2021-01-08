using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eurekaanimes5.Models
{
    public class Noticias
    {
        [Key]
        public int NewsID { get; set; }
        public string Title { get; set; }
        public string NewsPost { get; set; }
        public string NewsStatus { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public Categories Category { get; set; }
        public ICollection<Tags> Tags { get; set; }

    }
}