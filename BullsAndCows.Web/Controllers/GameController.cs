using BullsAndCows.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BullsAndCows.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly IGamesService gamesService;

        public GameController(IGamesService gamesService)
        {
            this.gamesService = gamesService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var activeUser = this.User;

            var numberToGuess = await this.gamesService.InitializeGame(activeUser);

            return View(numberToGuess);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Index(string model)
        {
            return View();
        }
    }
}