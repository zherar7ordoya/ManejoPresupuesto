using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "El {0} debe tener entre {2} y {1} caracteres.")]
        [DisplayName("Tipo de cuenta")]
        public string? Nombre { get; set; }

        public int UsuarioId { get; set; }

        public int Orden { get; set; }

        // Área de pruebas (otros tipos de validaciones).

        [Required(ErrorMessage = "{0} es requerido.")]
        [EmailAddress(ErrorMessage = "El {0} no es una dirección de correo válida.")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "{0} es requerido.")]
        [Range(minimum: 18, maximum: 99, ErrorMessage = "La {0} debe estar entre {1} y {2}.")]
        public int? Edad { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [Url(ErrorMessage = "La {0} no es una URL válida.")]
        public string? URL { get; set; }

        [Required(ErrorMessage = "{0} es requerido.")]
        [CreditCard(ErrorMessage = "La {0} no es una tarjeta de crédito válida.")]
        [DisplayName("Tarjeta de crédito")]
        public string? TarjetaDeCredito { get; set; }
    }
}
