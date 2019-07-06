using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BullsAndCows.Data.Common;
using Microsoft.AspNetCore.Identity;

namespace BullsAndCows.Data.Models
{
    public class BullsAndCowsUser : IdentityUser, IAuditableEntity, IDeletableEntity
    {
        public BullsAndCowsUser()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.Games = new List<Game>();
        }

        [NotMapped]
        public int Wins 
            => this.Games.Where(game => game.Status == GameStatus.Won).Count();

        [NotMapped]
        public int Losses
            => this.Games.Where(game => game.Status == GameStatus.Lost).Count();

        [NotMapped]
        public int TotalPoints => this.Wins * 3;
        //TODO: constant for the 3points on a win


        [NotMapped]
        public int TotalGames => this.Wins + this.Losses;

        [NotMapped]
        public string WinLossRatio
        {
            get
            {
                var ratio = (double) this.Wins / this.TotalGames;

                return $"{ratio * 100:f1}%";
            }
        }

        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }

        public List<Game> Games { get; set; }
    }
}
