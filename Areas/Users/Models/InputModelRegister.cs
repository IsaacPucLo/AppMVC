using System.ComponentModel.DataAnnotations;

namespace Moblarte.Areas.Users.Models
{
    public class InputModelRegister
    {

        [Required(ErrorMessage = "El campo nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo Id es obligatorio")]
        public string Id { get; set; }

        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})\)?[-. ]?([0-9]{5})\)$", ErrorMessage = "El formato de telefono no es valido")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo electronico no es valido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")] //Modifica el nombre que se mostrará al cliente de la propiedad
        [Required(ErrorMessage = "El campo telefono es obligatorio")]
        [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
