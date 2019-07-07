using System.Security.Claims;
using System.Threading.Tasks;
using BullsAndCows.Data;
using BullsAndCows.Data.Common;
using BullsAndCows.Data.Models;
using BullsAndCows.Models.ViewModels;
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
        public async Task<GameViewModel> InitializeGameAsync(ClaimsPrincipal principal)
        {
            var user = await this.userManager.GetUserAsync(principal);

            var game = new Game
            {
                User = user
            };

            await this.dbContext.Games.AddAsync(game);

            await this.dbContext.SaveChangesAsync();

            var gameViewModel = new GameViewModel
            {
                Id = game.Id,
                Number = game.Number
            };

            return gameViewModel;
        }

        public async Task ChangeGameStatusToWonAsync(string gameId)
        {
            var game = await this.dbContext.Games.FindAsync(gameId);
            game.Status = GameStatus.Won;

            await this.dbContext.SaveChangesAsync();
        }
    }
}
