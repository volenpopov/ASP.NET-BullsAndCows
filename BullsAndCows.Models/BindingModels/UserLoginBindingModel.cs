using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Models.BindingModels
{
    public class UserLoginBindingModel
    {

        [Required]
        [StringLength(25, MinimumLength = 5)]
        public string Username { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string StatusMessage { get; set; }
    }
}
