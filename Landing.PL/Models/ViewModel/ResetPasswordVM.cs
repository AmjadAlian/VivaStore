using Microsoft.CodeAnalysis.Completion;
using System.ComponentModel.DataAnnotations;

namespace Landing.PL.Models.ViewModel
{
    public class ResetPasswordVM
    {
        [Required(ErrorMessage ="Enter New Password")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set;}
        public string Email { get; set;}
        public string Token { get; set;}
    }
}
