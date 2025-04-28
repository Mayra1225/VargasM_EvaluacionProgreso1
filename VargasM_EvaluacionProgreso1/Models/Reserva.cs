using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal ValorAPagar { get; set; }

        // Relación con Cliente
        public int ClientesId { get; set; }
        [ForeignKey("ClientesId")]
        public Clientes? Clientes { get; set; }
    }
}
