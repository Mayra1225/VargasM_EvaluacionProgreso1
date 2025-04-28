using System.ComponentModel.DataAnnotations;

namespace VargasM_EvaluacionProgreso1.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Range(18, 100, ErrorMessage = "La edad debe ser entre 18 y 100 años")]
        public int Edad { get; set; }

        [DataType(DataType.Currency)]
        [Range(0.0, 10000.0, ErrorMessage = "El saldo debe estar entre 0 y 10,000")]
        public decimal Saldo { get; set; }

        public bool EsVIP { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; }
    }
}
