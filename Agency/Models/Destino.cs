using System.ComponentModel.DataAnnotations;

namespace Agency.Models
{
    public class Destino
    {
        [Key]
        [Required]

        public int Id_destino { get; set; }

        [Required]

        public string Localidade { get; set; }

        [Required]

        public string Ida { get; set; }

        [Required]

        public string Volta { get; set; }

        [Required]

        public decimal Valor { get; set; }

        [Required]

        public int clienteId_cliente { get; set; }

        public Cliente Cliente { get; set; }
    }
}