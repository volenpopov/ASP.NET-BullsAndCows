using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Models.ViewModels
{
    public class UserProfileViewModel : UserRankingViewModel
    {
        [Display(Name = "User since:")]
        public string CreatedOn { get; set; }        
    }
}
