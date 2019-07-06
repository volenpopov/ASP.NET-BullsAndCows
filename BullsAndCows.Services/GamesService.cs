using System.Security.Claims;
using System.Threading.Tasks;
using BullsAndCows.Data;
using BullsAndCows.Data.Models;
using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Identity;

namespace BullsAndCows.Services
{
    public class GamesService : IGamesService
    {
        private readonly BullsAndCowsDbContext dbContext;
        private readonly UserManager<BullsAndCowsUser> userManager;

        public GamesService(BullsAndCowsDbContext dbContext, UserManager<BullsAndCowsUser> userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }
        public async Task<int> InitializeGame(ClaimsPrincipal principal)
        {
            var user = await this.userManager.GetUserAsync(principal);

            var game = new Game
            {
                User = user
            };

            await this.dbContext.Games.AddAsync(game);

            await this.dbContext.SaveChangesAsync();

            return game.Number;
        }
    }
}
