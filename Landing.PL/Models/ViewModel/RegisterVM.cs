using System.ComponentModel.DataAnnotations;

namespace Landing.PL.Models.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage ="Enter User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Your Email")]
        [DataType(DataType.EmailAddress)]
        [MinLength(10)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password),ErrorMessage = "Password not match")]
        public string ConfirmPassword { get; set; }
    }
}
