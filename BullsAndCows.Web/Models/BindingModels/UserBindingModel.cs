using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Web.Models.BindingModels
{
    public class UserBindingModel
    {
        //TODO

        [Required]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Username must bet between 5 and 25 characters long!")]
        public string Username { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password must be at least 5 characters long!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
