using BullsAndCows.Common;
using BullsAndCows.Data.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace BullsAndCows.Data.Models
{
    public class BullsAndCowsUser : IdentityUser, IAuditableEntity, IDeletableEntity
    {
        public BullsAndCowsUser()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.Games = new HashSet<Game>();
        }

        [NotMapped]
        public int Wins 
            => this.Games.Where(game => game.Status == GameStatus.Won).Count();

        [NotMapped]
        public int Losses
            => this.Games.Where(game => game.Status == GameStatus.Lost).Count();

        [NotMapped]
        public int TotalPoints => this.Wins * GlobalConstants.PointsPerWin;        

        [NotMapped]
        public int TotalGames => this.Wins + this.Losses;

        [NotMapped]
        public double WinLossRatio
        {
            get
            {
                var totalGames = this.TotalGames;

                if (totalGames > 0)
                {
                    var ratio = (double)this.Wins / totalGames;
                    return ratio * 100;
                }

                return 0;
            }
        }

        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
