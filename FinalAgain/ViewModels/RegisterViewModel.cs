using System.ComponentModel.DataAnnotations;

namespace FinalAgain.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords are not matching.")]
        public string CheckPassword { get; set; }
        public string Role { get; set; }
        [Required]
        public int LoginId { get; set; }
    }
}
