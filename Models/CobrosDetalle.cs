using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlainaGarcia_Ap1_P1.Models;

public class CobrosDetalle
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
    public double ValorCobrado { get; set; }
}
