using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Web.Models.BindingModels
{
    public class UserBindingModel
    {
        //TODO: error msg constant

        [Required]
        [Display(Name = "Username")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "{0} must be between {2} and {1} characters long!")]
        public string Username { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "{0} must be between {2} and {1} characters long!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Invalid {0}!")]
        public string ConfirmPassword { get; set; }
    }
}
