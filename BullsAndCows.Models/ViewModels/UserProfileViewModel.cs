using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Models.ViewModels
{
    public class UserProfileViewModel
    {
        public string Username { get; set; }

        [Display(Name = "User since:")]
        public string CreatedOn { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        [Display(Name = "Games played:")]
        public int TotalGames => this.Wins + this.Losses;

        [Display(Name = "Total Points:")]
        public int TotalPoints { get; set; }

        [Display(Name = "Win/Loss Ratio:")]
        public string WinLossRatio { get; set; }
    }
}
