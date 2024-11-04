using System.ComponentModel.DataAnnotations;

namespace Landing.PL.Models.ViewModel
{
    public class ForgotPasswordVM
    {
        [Required(ErrorMessage = "Enter Your Email")]
        [DataType(DataType.EmailAddress)]
        [MinLength(10)]
        public string Email { get; set; }
    }
}
