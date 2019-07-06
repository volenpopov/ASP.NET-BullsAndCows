using System.ComponentModel.DataAnnotations;

namespace BullsAndCows.Models.ViewModels
{
    public class UserRankingViewModel
    {
        public string Username { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        [Display(Name = "Total Points:")]
        public int TotalPoints { get; set; }

        [Display(Name = "Total Games:")]
        public int TotalGames { get; set; }

        [Display(Name = "Win/Loss Ratio:")]
        public string WinLossRatio { get; set; }
    }
}
