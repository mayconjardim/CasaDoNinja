
using System.ComponentModel.DataAnnotations;


namespace CasaDoNinja.Shared
{
    public class UserChangePassword
    {

        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
     
        [Compare("Password", ErrorMessage = "As senhas não conferem.")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
