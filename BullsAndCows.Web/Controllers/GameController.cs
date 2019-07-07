using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BullsAndCows.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly IGamesService gamesService;
        private readonly IUsersService userService;

        public GameController(IGamesService gamesService, IUsersService userService)
        {
            this.gamesService = gamesService;
            this.userService = userService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var activeUser = this.User;

            var numberToGuess = await this.gamesService.InitializeGameAsync(activeUser);

            return View(numberToGuess);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Win(string gameId)
        {
            await this.gamesService.ChangeGameStatusToWonAsync(gameId);

            var userScore = await this.userService.GetUserScoreAsync(this.User);

            return View(userScore);
        }
    }
}