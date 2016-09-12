using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace INEQ.Models._17Login
{
    public class UserAccount
    {
        public int Id { get; set; }
    
        [Required(ErrorMessage = "Se requiere un nombre.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Se requiere un apellido.")]
        public string LastName { get; set; }
    
        [Required(ErrorMessage = "Se requiere un nombre de usuario.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Se requiere una contraseña.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public BitArray Active { get; set; }
    }
}