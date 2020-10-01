using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnionArchitecture.Web.ViewModels
{
    public class PersonViewModel
    {
        public int PersonId { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayName("Apellido")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayName("Telefono")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayName("Cedula")]
        public string IdentityCard { get; set; }
    }
}