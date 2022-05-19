using System.ComponentModel.DataAnnotations;

namespace Listino.Models
{

    public class Product
    {
        [Required]
        [Key]
        public string C8 { get; set; }
        public string Descrizione { get; set; }
        public string Titolo { get; set; }
        public string Link { get; set; }

    }
}
