using System.ComponentModel.DataAnnotations;

namespace Listino.Models
{
    public class Customer
    {
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascita { get; set; }

    }
}
