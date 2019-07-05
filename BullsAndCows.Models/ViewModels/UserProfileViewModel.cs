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

        public string WinLossRatio => $"{this.Wins / this.Losses:f1}";

        public int TotalGames => this.Wins + this.Losses;
        
        public int TotalPoints { get; set; }
    }
}
