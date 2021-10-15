using System.ComponentModel.DataAnnotations;

namespace SistemaBuscador.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo{0} es requerido")]
        public string Usuario { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo{0} es requerido")]
        public string Password { get; set; }
    }
}
