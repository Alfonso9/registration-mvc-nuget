using System.ComponentModel.DataAnnotations;

namespace RegistrationMVC.Models.Cuentas.Input
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [Display(Name = "Usuario")]
        [RegularExpression("([ ]{0,}[A-Za-z][A-Za-z0-9]{4,15}[ ]{0,}$)", ErrorMessage = "El campo {0} contiene caracteres no validos.")]
        [MinLength(4, ErrorMessage = "El campo {0} debe ser mayor a 4 caracteres.")]
        public string _Usuario { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DataType(DataType.Password, ErrorMessage = "ddd")]
        [Display(Name = "Contraseña")]
        [RegularExpression("([A-Za-z0-9_!@#$%^?&*-.]{6,})", ErrorMessage = "El campo {0} acepta sólo letras, numeros y caracteres especiales (_!@#$%?^&*-.).")]
        public string _Contrasenia { get; set; }

        [Required]
        [Display(Name = "Recordarme")]
        public bool _Recordarme { get; set; }
    }
}