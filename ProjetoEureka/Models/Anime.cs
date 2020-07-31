
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoEureka.Models
{
    [Table("euk_anime", Schema = "eureka")]
    public class Anime
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nome_JP { get; set; }
        public string Sinopse { get; set; }
        public string Trailer { get; set; }
        public int? Ano { get; set; }
        public string Status { get; set; }
        public int? Episodios { get; set; }
        public string Temporada { get; set; }
        public string Foi_ao_ar { get; set; }
        public string Tamanho { get; set; }
        public string Studio { get; set; }
        public string Tipo { get; set; }
        public byte[] Capa_anime { get; set; }
        public int Capa_pagina { get; set; }
        public int Data_criacao_pagina { get; set; }
        public int Meta_keys_pagina { get; set; }

    }
}
