using System.ComponentModel.DataAnnotations;

namespace api2.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public int idade { get; set; }

        
    }
}