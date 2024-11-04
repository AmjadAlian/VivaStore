using System.ComponentModel.DataAnnotations;

namespace Landing.PL.Models.ViewModel
{
    public class LoginVM
    {
     

        [Required(ErrorMessage = "Enter Your Email")]
        [DataType(DataType.EmailAddress)]
        [MinLength(10)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        
    }
}
