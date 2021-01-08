using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eurekaanimes5
{
    public class Categories
    {
        [Key]
        public int CatID { get; set; }
        public string CatName { get; set; }
    }
}