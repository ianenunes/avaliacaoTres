using System.ComponentModel.DataAnnotations;

namespace Agency.Models
{
    public class Cliente
    {
        [Key]
        [Required]

        public int Id_cliente { get; set; }

        [Required]

        public string Nome { get; set; }

        [Required]

        public string Endereco { get; set; }

        [Required]

        public string Email { get; set; }

        
    }
}