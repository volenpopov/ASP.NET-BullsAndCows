using BullsAndCows.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BullsAndCows.Data
{
    public class BullsAndCowsDbContext : IdentityDbContext<BullsAndCowsUser>
    {
        public DbSet<Game> Games { get; set; }
        public BullsAndCowsDbContext(DbContextOptions<BullsAndCowsDbContext> options)
            : base(options)
        { }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
