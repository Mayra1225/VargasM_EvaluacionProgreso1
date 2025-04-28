using System.ComponentModel.DataAnnotations;

namespace VargasM_EvaluacionProgreso1.Models
{
    public class Reserva
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaEntrada { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaSalida { get; set; }

        [DataType(DataType.Currency)]
        [Range(0, double.MaxValue, ErrorMessage = "El valor debe ser positivo")]
        public decimal ValorAPagar { get; set; }

        // Relación con Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
