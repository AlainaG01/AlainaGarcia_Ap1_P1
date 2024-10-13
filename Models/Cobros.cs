using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlainaGarcia_Ap1_P1.Models;

public class Cobros
{
    [Key]
    public int CobroId { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [ForeignKey("DeudorId")]
    public int DeudorId { get; set; }
    public Deudores? Deudor { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    public double Monto { get; set; }

    [ForeignKey("CobroId")]
    public ICollection<CobrosDetalle> CobroDetalle { get; set; } = new List<CobrosDetalle>();
}
