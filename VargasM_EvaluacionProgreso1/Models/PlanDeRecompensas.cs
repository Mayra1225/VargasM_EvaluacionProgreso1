using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VargasM_EvaluacionProgreso1.Models
{
    public class PlanDeRecompensas
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Range(0, int.MaxValue)]
        public int PuntosAcumulados { get; set; }

        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados >= 500 ? "GOLD" : "SILVER";
            }
        }

        public int ReservaId { get; set; }
        [ForeignKey("ReservaId")]
        public Reserva Reserva { get; set; }
    }
}
