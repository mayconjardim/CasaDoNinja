using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoNinja.Shared
{
    public class UserChangePassword
    {

        [Required, StringLength(100, MinimumLength = 60)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "As senhas estão diferentes!")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
