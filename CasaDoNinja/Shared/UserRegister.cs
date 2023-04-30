using System.ComponentModel.DataAnnotations;

namespace CasaDoNinja.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage ="As senhas estão diferentes!")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
