using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eurekaanimes5.Models
{
    public class Animes
    {
        [Key]
        public int AnimeID { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string English { get; set; }
        public string Romanji { get; set; }
        public string Japanese { get; set; }
        public string Type { get; set; }
        public string Episodes { get; set; }
        public string Status { get; set; }
        public string Aired { get; set; }
        public string Season { get; set; }
        public string Classification { get; set; }
        public string Producers { get; set; }
        public string Studio { get; set; }
        public string Duration { get; set; }
        public string Sinopse { get; set; }

        //Relacionamentos
        public int CategoryID { get; set; }
        public Categories Category { get; set; }
        public ICollection<Tags> Tags { get; set; }
    }
}