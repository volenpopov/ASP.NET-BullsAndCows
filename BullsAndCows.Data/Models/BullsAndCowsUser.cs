using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BullsAndCows.Data.Common;
using Microsoft.AspNetCore.Identity;

namespace BullsAndCows.Data.Models
{
    public class BullsAndCowsUser : IdentityUser, IAuditableEntity, IDeletableEntity
    {
        public BullsAndCowsUser()
        {
            this.CreatedOn = DateTime.UtcNow;
        }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int TotalPoints { get; set; }

        [NotMapped]
        public int TotalGames => this.Wins + this.Losses;

        [NotMapped]
        public string WinLossRatio
        {
            get
            {
                var ratio = (double)this.Wins / this.TotalGames;

                return $"{ratio * 100:f1}%";
            }
        }

        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
