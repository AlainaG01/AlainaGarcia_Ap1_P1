using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlainaGarcia_Ap1_P1.Models
{
    public class Deudores
    {
        [Key]
        public int DeudorId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras")]
        public string? Nombres { get; set; }
    }
}
