using System.ComponentModel.DataAnnotations;

namespace eurekaanimes5.Models
{
    public class Usuarios
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string User { get; set; }
    }
}