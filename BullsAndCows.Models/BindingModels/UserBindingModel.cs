using BullsAndCows.Common;
using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Models.BindingModels
{
    public class UserBindingModel
    {        
        [Required]
        [Display(Name = "Username")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = GlobalConstants.StringLengthErrorMsg)]
        public string Username { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5, ErrorMessage = GlobalConstants.StringLengthErrorMsg)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = GlobalConstants.InvalidParameterErrorMsg)]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
