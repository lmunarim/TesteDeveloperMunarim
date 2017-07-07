using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWebSite.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Campo Obrigatório")]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
    }
}
