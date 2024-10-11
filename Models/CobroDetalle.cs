using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlainaGarcia_Ap1_P1.Models;

public class CobroDetalle
{
    [Key]
    public int DetalleId { get; set; }

    [ForeignKey("CobroId")]
    public int CobroId { get; set; }
    public Cobros? Cobro { get; set; }

    [ForeignKey("PrestamoId")]
    public int PrestamoId { get; set; }
    public Prestamos? Prestamo { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression("^(?!0(\\.0+)?$)\\d+(\\.\\d+)?$", ErrorMessage = "El valor debe ser un número mayor que cero")]
    public double ValorCobrado { get; set; }
}
