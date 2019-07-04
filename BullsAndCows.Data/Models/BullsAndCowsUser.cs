using System;
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

        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
