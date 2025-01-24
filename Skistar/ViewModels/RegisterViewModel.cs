using System.ComponentModel.DataAnnotations;

namespace Skistar.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Du måste ange användarnamn")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Fyll i epost")]
        [EmailAddress(ErrorMessage = "Din epostadress är felaktig")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lösenord krävs")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bekräfta lösenordet")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Lösenorden matchar inte")]
        public string ConfirmPassword { get; set; }
    }
}
