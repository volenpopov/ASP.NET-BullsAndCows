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

        [NotMapped]
        public double WinLossRatio => this.Wins / this.Losses;

        public int TotalPoints { get; set; }

        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
