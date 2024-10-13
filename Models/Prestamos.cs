using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlainaGarcia_Ap1_P1.Models;

public class Prestamos
{

    [Key]
    public int PrestamosId { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras")]
    public string? Concepto { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Solo se permiten numeros enteros o decimales")]
    public double Monto { get; set; }
    
    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Solo se permiten numeros enteros o decimales")]
    public double Balance { get; set; }

    [ForeignKey("DeudorId")]
    public int DeudorId { get; set; }
    public Deudores? Deudor { get; set; }
}
