using System.ComponentModel.DataAnnotations;

namespace AlainaGarcia_Ap1_P1.Models;

public class Prestamos
{

    [Key]
    public int PrestamosId { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression("^[a-zA-Z/s]+$", ErrorMessage= "Solo letras no caracteres especiales")]
    public string Deudor {  get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    [RegularExpression("^[a-zA-Z/s]+$", ErrorMessage = "Solo letras no caracteres especiales")]
    public string Concepto { get; set; }

    [Required(ErrorMessage = "Campo obligatorio")]
    public double Monto { get; set; }
}
